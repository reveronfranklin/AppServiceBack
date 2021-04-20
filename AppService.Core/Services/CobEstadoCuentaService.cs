using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.SapEstadoCuentaResult;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class CobEstadoCuentaService: ICobEstadoCuentaService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ISapClient _sapClient;
        private readonly PaginationOptions _paginationOptions;

        public CobEstadoCuentaService(IUnitOfWork unitOfWork,
                                      IOptions<PaginationOptions> options,
                                      ISapClient sapClient)
        {
            _unitOfWork = unitOfWork;
            _sapClient = sapClient;
            _paginationOptions = options.Value;
        }

      

        public async Task<PagedList<CobEstadoDeCuenta>> GetEstadoCuenta(CobEstadoCuentaQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;
            filters.PageSize = 1000;

            //Busca Estado de Cuenta del cliente en Sap
            var estadoCuentaSap = await GetEstadoCuentaSap(filters.IdCliente);
            if (estadoCuentaSap!=null)
            {
                //Actualiza Tabla CobEstadoCuenta con el estado de cuenta Sap
                await UpdateCobEstadoCuenta(estadoCuentaSap, filters.IdCliente);


                var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetAllDocumentoMadre(filters.IdCliente);


                if (filters.Documento > 0)
                {
                    estadoCuenta = estadoCuenta.Where(x => x.Rpdoc == filters.Documento).ToList();

                }

                var pagedResult = PagedList<CobEstadoDeCuenta>.Create(estadoCuenta, filters.PageNumber, filters.PageSize);

                return pagedResult;
            }
            else
            {
                return null;
            }

        }

        public async Task<List<EstadoCuentaSap>> GetEstadoCuentaSap(string  cliente)
        {

          
                string userSap = _paginationOptions.UserSap;
                string passwordSap = _paginationOptions.PasswordSap;
                string tokenSap = "";
               
                var meta= await _sapClient.GetToken(userSap, passwordSap);
                if (meta.IsValid)
                {
                    tokenSap = meta.Message;

                }
                else
                {
                    return null;
                }
               

                string action = $"EstadoCuentaCliente?Sociedad='1000'&Cliente='{cliente}'&MostrarImportesMonedaDoc=true";

                var result = await _sapClient.GetEstadoCuenta(action, tokenSap);


                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                };
                AppService.Core.DTOs.SapEstadoCuentaResult.Application resultSapEstadoCuenta = new AppService.Core.DTOs.SapEstadoCuentaResult.Application();
                resultSapEstadoCuenta = JsonSerializer.Deserialize<AppService.Core.DTOs.SapEstadoCuentaResult.Application>(result.Message, options);
                List<EstadoCuentaSap> estadoCuentaSap = new List<EstadoCuentaSap>();
                foreach (var item in resultSapEstadoCuenta.d.results)
                {
                    EstadoCuentaSap itemEstadoCuentaSap = new EstadoCuentaSap();

                    itemEstadoCuentaSap.DocumentoSAP = item.DocumentoSAP;
                    itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                    itemEstadoCuentaSap.ClaseDoc = item.ClaseDoc;
                    itemEstadoCuentaSap.Correlativo = item.Correlativo;
                    itemEstadoCuentaSap.Cliente = item.Cliente;
                    itemEstadoCuentaSap.DocumentoExterno = item.DocumentoExterno;
                    itemEstadoCuentaSap.Moneda = item.Moneda;
                    var valor = long.Parse(GetSubStringByString("(", ")", item.FechaDoc));
                    var fecha = DateTimeOffset.FromUnixTimeMilliseconds(valor).DateTime;
                    itemEstadoCuentaSap.FechaDoc = fecha;
                    fecha = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(GetSubStringByString("(", ")", item.FechaVencimiento))).DateTime;
                    itemEstadoCuentaSap.FechaVencimiento = fecha;

                    itemEstadoCuentaSap.Monto = decimal.Parse(item.Monto);
                    itemEstadoCuentaSap.BaseImponible = decimal.Parse(item.BaseImponible);
                    itemEstadoCuentaSap.Impuesto = decimal.Parse(item.Impuesto);
                    itemEstadoCuentaSap.Saldo = decimal.Parse(item.Saldo);

                    estadoCuentaSap.Add(itemEstadoCuentaSap);

                }


                return estadoCuentaSap;

           

          
        }

        public async Task<CobEstadoDeCuenta> GetEstadoCuentaById(decimal id)
        {

            var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetById(id);

            return estadoCuenta;
        }

        public string GetSubStringByString(string a,string b,string c)
        {

            var result = c.Substring((c.IndexOf(a) + a.Length), (c.IndexOf(b) - c.IndexOf(a) - a.Length));
            
              return result;
        }


        public async Task UpdateCobEstadoCuenta(List<EstadoCuentaSap> estadoCuentaSaps,string idCliente)
        {

            foreach (var item    in estadoCuentaSaps)
            {

                CobEstadoDeCuenta cobEstadoDeCuenta = new CobEstadoDeCuenta();

                var estaddoCuentaSearch = await _unitOfWork.CobEstadoDeCuentaRepository.GetByDocumentoSap(item.DocumentoSAP);

                if (estaddoCuentaSearch== null)
                {
                    cobEstadoDeCuenta.DocumentoSap = item.DocumentoSAP;
                    cobEstadoDeCuenta.Rpdoc = double.Parse(item.DocumentoExterno);

                    var claseDocumento = GetListClaseDocumento().Where(x => x.ClaseDocumento == item.ClaseDoc).FirstOrDefault();
                    if (claseDocumento!=null)
                    {
                        cobEstadoDeCuenta.Rpdct = claseDocumento.TipoLegacy;
                    }
                    
                    cobEstadoDeCuenta.Rpkco = "01406";
                    cobEstadoDeCuenta.Rpsfx = "001";
                    cobEstadoDeCuenta.Rpan8 = double.Parse(item.Cliente);
                    cobEstadoDeCuenta.Rpag = decimal.ToDouble(item.Monto);
                    cobEstadoDeCuenta.Rpaap = decimal.ToDouble(item.Saldo);
                    cobEstadoDeCuenta.IdCliente = item.Cliente;
                    var cliente = _unitOfWork.MtrClienteRepository.GetById(item.Cliente);
                    cobEstadoDeCuenta.Vendedor = cliente.Vendedor1.Trim();
                    cobEstadoDeCuenta.OficinaVenta = cliente.OficinaVenta.Trim();
                    cobEstadoDeCuenta.BaseImponible = item.BaseImponible;
                    cobEstadoDeCuenta.Iva = item.Impuesto;
                    cobEstadoDeCuenta.MontoOriginal = item.Monto;
                    cobEstadoDeCuenta.FechaDocumento = item.FechaDoc;
                    cobEstadoDeCuenta.FechaVencimiento = item.FechaVencimiento;
                    cobEstadoDeCuenta.Moneda = item.Moneda;
                    await _unitOfWork.CobEstadoDeCuentaRepository.Add(cobEstadoDeCuenta);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    //estaddoCuentaSearch.DocumentoSap = item.DocumentoSAP;
                    estaddoCuentaSearch.Rpdoc = double.Parse(item.DocumentoExterno);
                    var claseDocumento = GetListClaseDocumento().Where(x => x.ClaseDocumento == item.ClaseDoc).FirstOrDefault();
                    if (claseDocumento != null)
                    {
                        estaddoCuentaSearch.Rpdct = claseDocumento.TipoLegacy;
                    }

                    estaddoCuentaSearch.Rpan8 = double.Parse(item.Cliente);
                    estaddoCuentaSearch.Rpag = decimal.ToDouble(item.Monto);
                    estaddoCuentaSearch.Rpaap = decimal.ToDouble(item.Saldo);
                    estaddoCuentaSearch.IdCliente = item.Cliente;
                    var cliente = _unitOfWork.MtrClienteRepository.GetById(item.Cliente);
                    estaddoCuentaSearch.Vendedor = cliente.Vendedor1;
                    estaddoCuentaSearch.OficinaVenta = cliente.OficinaVenta;
                    estaddoCuentaSearch.BaseImponible = item.BaseImponible;
                    estaddoCuentaSearch.Iva = item.Impuesto;
                    estaddoCuentaSearch.MontoOriginal = item.Monto;
                    estaddoCuentaSearch.FechaDocumento = item.FechaDoc;
                    estaddoCuentaSearch.FechaVencimiento = item.FechaVencimiento;
                    estaddoCuentaSearch.Moneda = item.Moneda;
                    _unitOfWork.CobEstadoDeCuentaRepository.Update(estaddoCuentaSearch);
                    await _unitOfWork.SaveChangesAsync();

                }


            }



            var estadoCuenta = await _unitOfWork.CobEstadoDeCuentaRepository.GetAllDocumentoMadre(idCliente);

            foreach (var item in estadoCuenta)
            {

               var  estadoCuentaSap =  estadoCuentaSaps.Where(x => x.DocumentoSAP == item.DocumentoSap).FirstOrDefault();
                if (estadoCuentaSap==null)
                {

                    var estaddoCuentaSearch = await _unitOfWork.CobEstadoDeCuentaRepository.GetByDocumentoSap(item.DocumentoSap);
                    estaddoCuentaSearch.Rpaap = 0;
                    _unitOfWork.CobEstadoDeCuentaRepository.Update(estaddoCuentaSearch);
                    await _unitOfWork.SaveChangesAsync();
                }

            }

        }


        public List<SAPClaseDocumentoDto> GetListClaseDocumento()
        {

            List<SAPClaseDocumentoDto> result = new List<SAPClaseDocumentoDto>();
           
            SAPClaseDocumentoDto item = new SAPClaseDocumentoDto();
            item.ClaseDocumento = "AB";
            item.TipoLegacy = "AB";
            result.Add(item);

            SAPClaseDocumentoDto item1 = new SAPClaseDocumentoDto();
            item1.ClaseDocumento = "CD";
            item1.TipoLegacy = "CD";
            result.Add(item1);

            SAPClaseDocumentoDto item2 = new SAPClaseDocumentoDto();
            item2.ClaseDocumento = "CI";
            item2.TipoLegacy = "SO";
            result.Add(item2);

            SAPClaseDocumentoDto item3 = new SAPClaseDocumentoDto();
            item3.ClaseDocumento = "DA";
            item3.TipoLegacy = "";
            result.Add(item3);

            SAPClaseDocumentoDto item4 = new SAPClaseDocumentoDto();
            item4.ClaseDocumento = "DG";
            item4.TipoLegacy = "DG";
            result.Add(item4);

            SAPClaseDocumentoDto item5 = new SAPClaseDocumentoDto();
            item5.ClaseDocumento = "DR";
            item5.TipoLegacy = "SO";
            result.Add(item5);

            SAPClaseDocumentoDto item6 = new SAPClaseDocumentoDto();

            item6.ClaseDocumento = "DV";
            item6.TipoLegacy = "DV";
            result.Add(item6);

            SAPClaseDocumentoDto item7 = new SAPClaseDocumentoDto();
            item7.ClaseDocumento = "DZ";
            item7.TipoLegacy = "RC";
            result.Add(item7);

            SAPClaseDocumentoDto item8 = new SAPClaseDocumentoDto();
            item8.ClaseDocumento = "RV";
            item8.TipoLegacy = "SO";
            result.Add(item8);

            SAPClaseDocumentoDto item9 = new SAPClaseDocumentoDto();
            item9.ClaseDocumento = "SA";
            item9.TipoLegacy = "SA";
            result.Add(item9);

            SAPClaseDocumentoDto item10 = new SAPClaseDocumentoDto();

            item10.ClaseDocumento = "Z0";
            item10.TipoLegacy = "SO";
            result.Add(item10);

            SAPClaseDocumentoDto item11 = new SAPClaseDocumentoDto();
            item11.ClaseDocumento = "Z1";
            item11.TipoLegacy = "SO";
            result.Add(item11);

            SAPClaseDocumentoDto item12 = new SAPClaseDocumentoDto();
            item12.ClaseDocumento = "Z2";
            item12.TipoLegacy = "SO";
            result.Add(item12);

            SAPClaseDocumentoDto item13 = new SAPClaseDocumentoDto();
            item13.ClaseDocumento = "Z5";
            item13.TipoLegacy = "CO";
            result.Add(item13);

            SAPClaseDocumentoDto item14 = new SAPClaseDocumentoDto();
            item14.ClaseDocumento = "Z7";
            item14.TipoLegacy = "SN";
            result.Add(item14);

            SAPClaseDocumentoDto item15 = new SAPClaseDocumentoDto();
            item15.ClaseDocumento = "ZA";
            item15.TipoLegacy = "ZA";
            result.Add(item15);

            SAPClaseDocumentoDto item16 = new SAPClaseDocumentoDto();
            item16.ClaseDocumento = "ZX";
            item16.TipoLegacy = "ZX";
            result.Add(item16);

            SAPClaseDocumentoDto item17 = new SAPClaseDocumentoDto();

            item17.ClaseDocumento = "ZZ";
            item17.TipoLegacy = "ZZ";
            result.Add(item17);


            return result;


        }

    }
}
