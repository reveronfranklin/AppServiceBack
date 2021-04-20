using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;

using AppService.Core.Enumerations;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AppService.Core.Utility;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fractional;

namespace AppService.Core.Services
{
    public class CotizacionService: ICotizacionService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;
        private readonly IMapper _mapper;
        private readonly IAppUnitsService _appUnitsService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;

        public CotizacionService(IUnitOfWork unitOfWork,
                                     IOptions<PaginationOptions> options,
                                     IMapper mapper,
                                     IAppUnitsService appUnitsService,
                                     IMtrTipoMonedaService mtrTipoMonedaService)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = options.Value;
            _mapper = mapper;
            _appUnitsService = appUnitsService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
        }

        public async Task<List<Wsmy501>> GetAll()
        {

            List<Wsmy501> cotizaciones = await _unitOfWork.CotizacionRepository.GetAll();

            return cotizaciones;
        }

      

        public async Task<Wsmy501> GetById(int id)
        {
            return await _unitOfWork.CotizacionRepository.GetById(id);
        }

        public async Task<Wsmy501> GetByCotizacion(string cotizacion)
        {
            return await _unitOfWork.CotizacionRepository.GetByCotizacion(cotizacion);
        }

        public async Task<Wsmy501> Insert(Wsmy501 cotizacion)
        {


            await _unitOfWork.CotizacionRepository.Add(cotizacion);
            await _unitOfWork.SaveChangesAsync();
            return cotizacion;


        }

        public async Task<ApiResponse<CotizacionGetDto>> CreateCotizacion(CotizacionCreateDto dto)
        {

            CotizacionGetDto resultDto = new CotizacionGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<CotizacionGetDto> response = new ApiResponse<CotizacionGetDto>(resultDto);


            try
            {
                Wsmy501 cotizacion = _mapper.Map<Wsmy501>(dto);

                var inserted = await Insert(cotizacion);

                resultDto = _mapper.Map<CotizacionGetDto>(inserted);

               


             

                response.Data = resultDto;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }




        public async Task<Wsmy501> Update(Wsmy501 cotizacion)
        {

            Wsmy501 cotizacionFind = await GetByCotizacion(cotizacion.Cotizacion);
            if (cotizacionFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.CotizacionRepository.Update(cotizacion);
            await _unitOfWork.SaveChangesAsync();

            return await GetByCotizacion(cotizacion.Cotizacion);


        }

        public async Task<ApiResponse<CotizacionGetDto>> UpdateCotizacion(CotizacionUpdateDto dto)
        {

            CotizacionGetDto resultDto = new CotizacionGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<CotizacionGetDto> response = new ApiResponse<CotizacionGetDto>(resultDto);


            try
            {

                var cotizacionFind = await GetByCotizacion(dto.Cotizacion);
                if (cotizacionFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacione No existe";
                    response.Data = resultDto;
                    response.Meta = metadata;
                    return response;
                }

                //TODO
                // asignar campo a campo de la cotizacion

                var updated = await Update(cotizacionFind);

                resultDto = _mapper.Map<CotizacionGetDto>(updated);

              


               

                response.Data = resultDto;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }
        public async Task<bool> Delete(string cotizacion)
        {
            await _unitOfWork.CotizacionRepository.Delete(cotizacion);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<ApiResponse<bool>> DeleteCotizacionOld(CotizacionDeleteDtocs dto)
        {
            bool resultDto = true;

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);

            try
            {

                Wsmy501 cotizacion = await GetByCotizacion(dto.Cotizacion);

                if (cotizacion == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Cotizacion No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

            

                resultDto = await Delete(cotizacion.Cotizacion);

                metadata.IsValid = true;
                metadata.Message = $"Cotizacion Eliminada Satisfactoriamente!";

                response.Meta = metadata;
                response.Data = resultDto;

                return response;
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;

                metadata.Message = ex.InnerException.Message;

                response.Meta = metadata;
                response.Data = resultDto;

                return response;

            }






        }




        public async Task IntegrarCotizacion(int generalQuotesId)
        {

            var generalQuotes = await _unitOfWork.AppGeneralQuotesRepository.GetById(generalQuotesId);

            if (generalQuotes != null)
            {

                await UpdateGeneralCotizacion(generalQuotes);

                if (generalQuotes.AppDetailQuotes.Count > 0)
                {
                    foreach (var item in generalQuotes.AppDetailQuotes)
                    {
                        await UpdateDetailCotizacion(item);
                    }
                }


            }

        }

        public async Task UpdateGeneralCotizacion(AppGeneralQuotes generalQuotes)
        {
            var cotizacion = await _unitOfWork.CotizacionRepository.GetByCotizacion(generalQuotes.Cotizacion);
            if (cotizacion != null)
            {
                cotizacion.CodCliente = generalQuotes.IdCliente;
                cotizacion.CodVendedor = generalQuotes.IdVendedor;
                if (cotizacion.CodCliente == "000000")
                {
                    cotizacion.Prospecto = "X";
                }
                else
                {
                    cotizacion.Prospecto = "";

                }
                cotizacion.FlagValidado = true;
                cotizacion.Fecha = generalQuotes.Fecha;
                cotizacion.Observaciones = generalQuotes.Observaciones;
                cotizacion.FechaCaducidad = generalQuotes.FechaCaducidad;
                cotizacion.FechaPostergada = generalQuotes.FechaPostergada;
                cotizacion.Estatus = generalQuotes.IdEstatus;
                cotizacion.Observaciones = generalQuotes.Observaciones;

                var cliente = _unitOfWork.MtrClienteRepository.GetById(generalQuotes.IdCliente);

               
               

                cotizacion.EmailCliente = cliente.EMailClient;
                
                cotizacion.Condicion = generalQuotes.IdCondPago;
               
                cotizacion.ObservacionPostergar = generalQuotes.ObservacionPostergar;
                cotizacion.UsuarioActualiza = generalQuotes.UsuarioActualiza;
                cotizacion.FechaActualiza = generalQuotes.FechaActualiza;
                cotizacion.IdContacto = (int)generalQuotes.IdContacto;
                var contacto =await  _unitOfWork.MtrContactosRepository.GetById((int)cotizacion.IdContacto);
                cotizacion.NombreContacto = contacto.Nombre;
                cotizacion.TelefonoContacto = contacto.Telefono1;
                cotizacion.EmailContacto = contacto.Email;
                cotizacion.IdDireccion = generalQuotes.IdDireccionFacturar;

                cotizacion.IdTipoTransaccion = "TRA";


                var direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(generalQuotes.IdDireccionFacturar);

                cotizacion.DireccionFacturar = direccionFacturar.Direccion + direccionFacturar.Direccion1 + direccionFacturar.Direccion2;

                var direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(generalQuotes.IdDireccionEntregar);


                if (cliente.Codigo.Trim() == "000000")
                {
                    cotizacion.RazonSocial = generalQuotes.RazonSocial;
                    cotizacion.Rif = generalQuotes.Rif;
                    cotizacion.DireccionEntregar = generalQuotes.Direccion;
                    cotizacion.RifEntregar = generalQuotes.Rif;
                }
                else
                {
                    cotizacion.RazonSocial = cliente.Nombre;
                    cotizacion.Rif = cliente.NoRegTribut;
                    cotizacion.DireccionEntregar = direccionEntregar.Direccion + direccionEntregar.Direccion1 + direccionEntregar.Direccion2;

                    cotizacion.RifEntregar = direccionEntregar.Rif;
                }

               



                cotizacion.OrdenCompra = generalQuotes.OrdenCompra;

                cotizacion.FlagActualizado = "X";
                cotizacion.IdDireccionEntregar = generalQuotes.IdDireccionEntregar;
                if (generalQuotes.IdMtrTipoMoneda == 1)
                {
                    cotizacion.NegocioEnUsd = true;
                }
                else
                {
                    cotizacion.NegocioEnUsd = false;
                }
                cotizacion.FijarPrecioBs = generalQuotes.FijarPrecioBs;

                cotizacion.OrigenExterno = true;


                _unitOfWork.CotizacionRepository.Update(cotizacion);
                await _unitOfWork.SaveChangesAsync();


            }
            else
            {

                Wsmy501 cotizacionNew = new Wsmy501();

                cotizacionNew.Cotizacion = generalQuotes.Cotizacion;


                cotizacionNew.CodCliente = generalQuotes.IdCliente;
                cotizacionNew.CodVendedor = generalQuotes.IdVendedor;
                if (cotizacionNew.CodCliente.Trim() == "000000")
                {
                    cotizacionNew.Prospecto = "X";
                }
                else
                {
                    cotizacionNew.Prospecto = "";

                }
                cotizacionNew.FlagValidado = true;
                cotizacionNew.Fecha = generalQuotes.Fecha;
                cotizacionNew.Observaciones = generalQuotes.Observaciones;
                cotizacionNew.FechaCaducidad = generalQuotes.FechaCaducidad;
                cotizacionNew.FechaPostergada = generalQuotes.FechaPostergada;
                cotizacionNew.Estatus = generalQuotes.IdEstatus;
                cotizacionNew.Observaciones = generalQuotes.Observaciones;
                var cliente = _unitOfWork.MtrClienteRepository.GetById(generalQuotes.IdCliente);

               

                cotizacionNew.EmailCliente = cliente.EMailClient;
                
                cotizacionNew.Condicion = generalQuotes.IdCondPago;
                cotizacionNew.IdContacto = (int)generalQuotes.IdContacto;
                cotizacionNew.ObservacionPostergar = generalQuotes.ObservacionPostergar;
                cotizacionNew.UsuarioActualiza = generalQuotes.UsuarioActualiza;
                cotizacionNew.FechaActualiza = generalQuotes.FechaActualiza;

                cotizacionNew.IdTipoTransaccion = "TRA";


                var contacto = await _unitOfWork.MtrContactosRepository.GetById((int)cotizacionNew.IdContacto);
                cotizacionNew.NombreContacto = contacto.Nombre;
                cotizacionNew.TelefonoContacto = contacto.Telefono1;
               
                cotizacionNew.IdDireccion = generalQuotes.IdDireccionFacturar;

                var direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(generalQuotes.IdDireccionFacturar);

                cotizacionNew.DireccionFacturar = direccionFacturar.Direccion + direccionFacturar.Direccion1 + direccionFacturar.Direccion2;

                var direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(generalQuotes.IdDireccionEntregar);

                if (cotizacionNew.CodCliente == "000000")
                {
                    cotizacionNew.RazonSocial = generalQuotes.RazonSocial;
                    cotizacionNew.Rif = generalQuotes.Rif;
                    cotizacionNew.DireccionEntregar = generalQuotes.Direccion;

                    cotizacionNew.RifEntregar = generalQuotes.Rif;

                }
                else
                {
                    cotizacionNew.RazonSocial = cliente.Nombre;
                    cotizacionNew.Rif = cliente.NoRegTribut;
                    cotizacionNew.DireccionEntregar = direccionEntregar.Direccion + direccionEntregar.Direccion1 + direccionEntregar.Direccion2;

                    cotizacionNew.RifEntregar = direccionEntregar.Rif;
                }
                  


                cotizacionNew.OrdenCompra = generalQuotes.OrdenCompra;

                cotizacionNew.FlagActualizado = "X";
                cotizacionNew.IdDireccionEntregar = generalQuotes.IdDireccionEntregar;
                if (generalQuotes.IdMtrTipoMoneda == 1)
                {
                    cotizacionNew.NegocioEnUsd = true;
                }
                else
                {
                    cotizacionNew.NegocioEnUsd = false;
                }

                cotizacionNew.FijarPrecioBs = generalQuotes.FijarPrecioBs;
                cotizacionNew.OrigenExterno = true;

                _unitOfWork.CotizacionRepository.Add(cotizacionNew);
                await _unitOfWork.SaveChangesAsync();

            }



        }
        public async Task UpdateDetailCotizacion(AppDetailQuotes appDetailQuotes)
        {

            var appProducts = await _unitOfWork.AppProductsRepository.GetById(appDetailQuotes.IdProducto);


            var renglon = await _unitOfWork.RenglonRepository.GetByCotizacionProducto(appDetailQuotes.Cotizacion, appProducts.ExternalCode);
            if (renglon != null)
            {
                renglon.Descripcion = appDetailQuotes.NombreComercialProducto;
                renglon.Estatus = appDetailQuotes.IdEstatus;
                renglon.RazonGanadaPerdida = appDetailQuotes.RazonGanadaPerdida;
                renglon.Competidor = appDetailQuotes.Competidor;
                var unidad = await _unitOfWork.AppUnitsRepository.GetById(appDetailQuotes.IdUnidad);

                renglon.UnidadCotizacion = unidad.Code;
                renglon.Observaciones = appDetailQuotes.Observaciones;
                renglon.TiempoEntrega = appDetailQuotes.DiasEntrega;
                renglon.Probabilidad = 50;
                renglon.FechaRegistro = appDetailQuotes.AppGeneralQuotes.Fecha;
                renglon.TotalRenglon = appDetailQuotes.Total;
                renglon.TotalRenglonUsd = appDetailQuotes.TotalUsd;
                if (appDetailQuotes.IdEstatusNavigation.FlagGanada == "X")
                {
                    renglon.TotalGanado = appDetailQuotes.Total;
                    renglon.TotalGanadoUsd = appDetailQuotes.TotalUsd;
                    renglon.EstatusPlanta = "V";
                }
                //TODO pendiente la subcategoria
                //renglon.SubCategoria=1
                var csmy036 = await _unitOfWork.Csmy036Repository.GetByCode(renglon.CodProducto);
                if (csmy036!=null)
                {
                    renglon.SubCategoria = (int)csmy036.Idsubcategoria;
                }

                _unitOfWork.RenglonRepository.Update(renglon);
                await _unitOfWork.SaveChangesAsync();

                await UpdatePropuestaCotizacion(appDetailQuotes, renglon.Renglon);
                if (appProducts.RequiereDatosEntrada)
                {
                    await UpdateWpry229(appDetailQuotes, renglon.Renglon);
                    await UpdateWpry240(appDetailQuotes, renglon.Renglon);
                    await UpdateWpry241(appDetailQuotes, renglon.Renglon);

                }


            }
            else
            {
                Wsmy502 renglonNew = new Wsmy502();
                renglonNew.Cotizacion = appDetailQuotes.Cotizacion;
                renglonNew.Renglon = await getNextRenglon(appDetailQuotes.Cotizacion);
                renglonNew.CodProducto = appDetailQuotes.IdProductoNavigation.ExternalCode;
                renglonNew.Descripcion = appDetailQuotes.NombreComercialProducto;
                renglonNew.Estatus = appDetailQuotes.IdEstatus;
                renglonNew.RazonGanadaPerdida = appDetailQuotes.RazonGanadaPerdida;
                renglonNew.Competidor = appDetailQuotes.Competidor;
                if (appDetailQuotes.IdUnidadNavigation != null)
                {
                    renglonNew.UnidadCotizacion = appDetailQuotes.IdUnidadNavigation.Code;
                }
                else
                {
                    var unidad = await _unitOfWork.AppUnitsRepository.GetById(appDetailQuotes.IdUnidad);
                    renglonNew.UnidadCotizacion = unidad.Code;
                }
               
                renglonNew.Observaciones = appDetailQuotes.Observaciones;
                renglonNew.TiempoEntrega = appDetailQuotes.DiasEntrega;
                renglonNew.Probabilidad = 50;
                renglonNew.FechaRegistro = appDetailQuotes.AppGeneralQuotes.Fecha;
                renglonNew.TotalRenglon = appDetailQuotes.Total;
                renglonNew.TotalRenglonUsd = appDetailQuotes.TotalUsd;
                if (appDetailQuotes.IdEstatusNavigation.FlagGanada == "X")
                {
                    renglonNew.TotalGanado = appDetailQuotes.Total;
                    renglonNew.TotalGanadoUsd = appDetailQuotes.TotalUsd;
                }
                //TODO pendiente la subcategoria
                //renglon.SubCategoria=1
                var csmy036 = await _unitOfWork.Csmy036Repository.GetByCode(renglonNew.CodProducto);
                if (csmy036 != null)
                {
                    renglonNew.SubCategoria = (int)csmy036.Idsubcategoria;
                }
                await _unitOfWork.RenglonRepository.Add(renglonNew);
                await _unitOfWork.SaveChangesAsync();

                await UpdatePropuestaCotizacion(appDetailQuotes, renglonNew.Renglon);

                if (appProducts.RequiereDatosEntrada)
                {
                    await UpdateWpry229(appDetailQuotes, renglonNew.Renglon);
                    await UpdateWpry240(appDetailQuotes, renglonNew.Renglon);
                    await UpdateWpry241(appDetailQuotes, renglonNew.Renglon);
                }
                    
            }


        }

        public async Task UpdatePropuestaCotizacion(AppDetailQuotes appDetailQuotes, int renglon)
        {



            var valoresCotizacion = await ValoresCotizacion(appDetailQuotes);


            var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(appDetailQuotes.Cotizacion, renglon, 1);
            if (propuesta != null)
            {
                propuesta.Cantidad = (decimal)valoresCotizacion.CantMill;
                propuesta.CantFormas = valoresCotizacion.CantFormas;
                propuesta.CantMill = valoresCotizacion.CantMill;

                propuesta.PrecioUnitario = valoresCotizacion.PrecioUnitario;
                propuesta.TotalPropuesta = valoresCotizacion.TotalPropuesta;

                propuesta.PrecioUnitarioUsd = valoresCotizacion.PrecioUnitarioUsd;
                propuesta.TotalPropuestaUsd = valoresCotizacion.TotalPropuestaUsd;



                //Actualizacion de variables externas
                propuesta.PrecioUnitarioExterno = valoresCotizacion.PrecioUnitarioExterno;
                propuesta.TotalPropuestaExterno = valoresCotizacion.TotalPropuestaExterno;
                propuesta.PrecioUnitarioUsdExterno = valoresCotizacion.PrecioUnitarioUsdExterno;
                propuesta.TotalPropuestaUsdExterno = valoresCotizacion.TotalPropuestaUsdExterno;
                propuesta.CantidadExterno = valoresCotizacion.CantidadExterno;
                propuesta.IdUnidadExterna = valoresCotizacion.IdUnidadExterna;
                propuesta.CodeUnidadExterna = valoresCotizacion.CodeUnidadExterna;
                propuesta.DescripcionUnidadExterna = valoresCotizacion.DescripcionUnidadExterna;
                propuesta.ValorConvertidoExterno = valoresCotizacion.ValorConvertidoExterno;
                propuesta.CantidadPorUnidadProduccion = valoresCotizacion.CantidadPorUnidadProduccion;
                propuesta.CantidadSolicitadaExterna = valoresCotizacion.CantidadSolicitadaExterna;
                propuesta.IdUnidadPrecio = valoresCotizacion.IdUnidadPrecio;
                propuesta.CodeUnidaPrecio = valoresCotizacion.CodeUnidaPrecio;





                propuesta.Estatus = appDetailQuotes.IdEstatus;


                propuesta.Observaciones = appDetailQuotes.Observaciones;
                propuesta.CantXCaja = appDetailQuotes.QuantityPerPackage;
                propuesta.Cajas = propuesta.Cantidad / appDetailQuotes.QuantityPerPackage;



                var csmy036 = await _unitOfWork.Csmy036Repository.GetByCode(appDetailQuotes.IdProductoNavigation.ExternalCode);
                if (csmy036 != null)
                {
                    propuesta.UnidadCosteo = csmy036.UnidadCosteo;
                }




                propuesta.Cajas = propuesta.Cantidad / propuesta.CantXCaja;

                propuesta.CotizacionRenglonPropuesta = propuesta.Cotizacion + propuesta.Renglon.ToString() + propuesta.Propuesta.ToString();


                propuesta.UsdListaCpj = appDetailQuotes.IdProductoNavigation.UnitPrice;
                propuesta.UsdListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice;
                propuesta.TotalUsdListaCpj = appDetailQuotes.IdProductoNavigation.UnitPrice * appDetailQuotes.Cantidad;
                propuesta.TotalUsdListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice * appDetailQuotes.Cantidad;


                var tasa = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(DateTime.Now);

                propuesta.BsListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice* tasa.Tasa;
                propuesta.TotalBsListaCpjminimo = propuesta.BsListaCpjminimo  * appDetailQuotes.Cantidad; 

                // wppy022.codigo se busca por Wsmy502.Unidad_Cotizacion 

                var renglonObj = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(propuesta.Cotizacion, propuesta.Renglon);

                
                propuesta.IdPresentacion = renglonObj.UnidadCotizacion; 
                //Valores no manejados por esta app
                propuesta.PorMc = 0;
                propuesta.BsMc = 0;
                propuesta.ImpresionTiro = "";
                propuesta.ImpresionRetiro = "";
                propuesta.Medidas =0;
                propuesta.Papel = "";
                propuesta.Partes = 0;
                propuesta.Respaldo = "";
                propuesta.MedidaTexto = "";
                propuesta.LoteAct = 0;
                propuesta.RecalcularMargen = "";


                _unitOfWork.PropuestaRepository.Update(propuesta);
                await _unitOfWork.SaveChangesAsync();
            }
            else
            {
                Wsmy515 propuestaNew = new Wsmy515();
                propuestaNew.Cotizacion = appDetailQuotes.Cotizacion;
                propuestaNew.Renglon = renglon;
                propuestaNew.Propuesta = 1;


                propuestaNew.Cantidad = (decimal)valoresCotizacion.CantMill;
                propuestaNew.CantFormas = valoresCotizacion.CantFormas;
                propuestaNew.CantMill = valoresCotizacion.CantMill;

                propuestaNew.PrecioUnitario = valoresCotizacion.PrecioUnitario;
                propuestaNew.TotalPropuesta = valoresCotizacion.TotalPropuesta;

                propuestaNew.PrecioUnitarioUsd = valoresCotizacion.PrecioUnitarioUsd;
                propuestaNew.TotalPropuestaUsd = valoresCotizacion.TotalPropuestaUsd;


                //Actualizacion de variables externas
                propuestaNew.PrecioUnitarioExterno = valoresCotizacion.PrecioUnitarioExterno;
                propuestaNew.TotalPropuestaExterno = valoresCotizacion.TotalPropuestaExterno;
                propuestaNew.PrecioUnitarioUsdExterno = valoresCotizacion.PrecioUnitarioUsdExterno;
                propuestaNew.TotalPropuestaUsdExterno = valoresCotizacion.TotalPropuestaUsdExterno;
                propuestaNew.CantidadExterno = valoresCotizacion.CantidadExterno;
                propuestaNew.IdUnidadExterna = valoresCotizacion.IdUnidadExterna;
                propuestaNew.CodeUnidadExterna = valoresCotizacion.CodeUnidadExterna;
                propuestaNew.DescripcionUnidadExterna = valoresCotizacion.DescripcionUnidadExterna;
                propuestaNew.ValorConvertidoExterno = valoresCotizacion.ValorConvertidoExterno;
                propuestaNew.CantidadPorUnidadProduccion = valoresCotizacion.CantidadPorUnidadProduccion;
                propuestaNew.CantidadSolicitadaExterna = valoresCotizacion.CantidadSolicitadaExterna;
                propuestaNew.IdUnidadPrecio = valoresCotizacion.IdUnidadPrecio;
                propuestaNew.CodeUnidaPrecio = valoresCotizacion.CodeUnidaPrecio;




                propuestaNew.Estatus = appDetailQuotes.IdEstatus;
                
                
                propuestaNew.Observaciones = appDetailQuotes.Observaciones;
                propuestaNew.CantXCaja = appDetailQuotes.QuantityPerPackage;
                propuestaNew.Cajas = propuestaNew.Cantidad / appDetailQuotes.QuantityPerPackage;

                var csmy036 = await _unitOfWork.Csmy036Repository.GetByCode(appDetailQuotes.IdProductoNavigation.ExternalCode);
                if (csmy036 != null)
                {
                    propuestaNew.UnidadCosteo = csmy036.UnidadCosteo;
                }



               
                propuestaNew.Cajas = propuestaNew.Cantidad / propuestaNew.CantXCaja;

                propuestaNew.CotizacionRenglonPropuesta = propuestaNew.Cotizacion + propuestaNew.Renglon.ToString() + propuestaNew.Propuesta.ToString();


                propuestaNew.UsdListaCpj = appDetailQuotes.IdProductoNavigation.UnitPrice;
                propuestaNew.UsdListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice;
                propuestaNew.TotalUsdListaCpj = appDetailQuotes.IdProductoNavigation.UnitPrice * appDetailQuotes.Cantidad;
                propuestaNew.TotalUsdListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice * appDetailQuotes.Cantidad;


                var tasa = await _unitOfWork.TPaTasaReferencialRepository.GetTasaByFecha(DateTime.Now);

                propuestaNew.BsListaCpjminimo = appDetailQuotes.IdProductoNavigation.UnitPrice * tasa.Tasa;
                propuestaNew.TotalBsListaCpjminimo = propuestaNew.BsListaCpjminimo * appDetailQuotes.Cantidad; ;



                var renglonObj = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(propuestaNew.Cotizacion, propuestaNew.Renglon);


                propuestaNew.IdPresentacion = renglonObj.UnidadCotizacion;
               



                //Valores no manejados por esta app
                propuestaNew.PorMc = 0;
                propuestaNew.BsMc = 0;
                propuestaNew.ImpresionTiro = "";
                propuestaNew.ImpresionRetiro = "";
                propuestaNew.Medidas = 0;
                propuestaNew.Papel = "";
                propuestaNew.Partes = 0;
                propuestaNew.Respaldo = "";
                propuestaNew.MedidaTexto = "";
                propuestaNew.LoteAct = 0;
                propuestaNew.RecalcularMargen = "";
                await _unitOfWork.PropuestaRepository.Add(propuestaNew);
                await _unitOfWork.SaveChangesAsync();

            }


        }


        public async Task UpdateWpry229(AppDetailQuotes appDetailQuotes, int renglon)
        {

            var valoresCotizacion = await ValoresCotizacion(appDetailQuotes);

            var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(appDetailQuotes.Cotizacion, renglon, 1);
            if (propuesta != null)
            {

                var aplicacionProducto = await _unitOfWork.Wsmy406Repository.GetByProduct(appDetailQuotes.IdProductoNavigation.ExternalCode);


                var wpry229 = await _unitOfWork.Wpry229Repository.GetByCotizacionRenglonPropuesta(propuesta.Cotizacion, propuesta.Renglon, propuesta.Propuesta);
                if (wpry229!=null)
                {
                    wpry229.CantidadProducto = (decimal)valoresCotizacion.CantMill;
                    wpry229.DescripcionSolicitud = appDetailQuotes.NombreComercialProducto;
                    wpry229.IdTipoProducto = aplicacionProducto.CodAplicacion;
                    wpry229.ValorVenta = (decimal)valoresCotizacion.PrecioUnitario;
                    wpry229.ValorLista = (decimal)valoresCotizacion.PrecioUnitario;
                    wpry229.ValorVentaUsd = valoresCotizacion.PrecioUnitarioUsd;
                    wpry229.Observaciones = appDetailQuotes.Observaciones;
                    wpry229.TipoOrden = (short)TipoOrdenEnum.NUEVA;
                    wpry229.IdTipoCantidad = 1;
                    _unitOfWork.Wpry229Repository.Update(wpry229);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {

                    Wpry229 wpry229New = new Wpry229();
                    wpry229New.Cotizacion = propuesta.Cotizacion;
                    wpry229New.Renglon = propuesta.Renglon;
                    wpry229New.Propuesta = propuesta.Propuesta;
                    wpry229New.CantidadProducto = (decimal)valoresCotizacion.CantMill;
                    wpry229New.DescripcionSolicitud = appDetailQuotes.NombreComercialProducto;
                    wpry229New.IdTipoProducto = aplicacionProducto.CodAplicacion;
                    wpry229New.ValorVenta = (decimal)valoresCotizacion.PrecioUnitario;
                    wpry229New.ValorLista = (decimal)valoresCotizacion.PrecioUnitario;
                    wpry229New.ValorVentaUsd = valoresCotizacion.PrecioUnitarioUsd;
                    wpry229New.Observaciones = appDetailQuotes.Observaciones;
                    wpry229New.TipoOrden = (short)TipoOrdenEnum.NUEVA;
                    wpry229New.IdTipoCantidad = 1;

                    await _unitOfWork.Wpry229Repository.Add(wpry229New);
                    await _unitOfWork.SaveChangesAsync();

                }


                
            }
          


        }


        public async Task UpdateWpry240(AppDetailQuotes appDetailQuotes, int renglon)
        {


            //await updateMedidas();

            const double factorPulgada = 2.54;




            var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(appDetailQuotes.Cotizacion, renglon, 1);
            if (propuesta != null)
            {

                string VariablePapel = "PAPEL";


                var receta = await _unitOfWork.AppRecipesRepository.GetListRecipesByProductIdVariableCode(appDetailQuotes.IdProducto, VariablePapel);

                if (receta!=null)
                {
                    foreach (var itemReceta in receta)
                    {
                        var ingrediente = await _unitOfWork.AppIngredientsRepository.GetById((int)itemReceta.AppIngredientsId);

                        int parte = itemReceta.Secuencia;



                        var wpry240 = await _unitOfWork.Wpry240Repository.GetByCotizacionRenglonPropuestaParte(propuesta.Cotizacion, propuesta.Renglon, propuesta.Propuesta, parte);
                        if (wpry240 != null)
                        {
                            wpry240.IdParte = parte;
                            wpry240.IdPapel = ingrediente.Code;
                            wpry240.Cantidad = (decimal)propuesta.Cantidad;
                            wpry240.FechaRegistro = DateTime.Now;

                            var basica = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotes.Id, "MEDIDABASICA");
                            //Covierte Centimetros a Pulgadas
                           
                            
                            var basicaPulgada = basica.Value / (decimal)factorPulgada;
                            basicaPulgada = (Math.Truncate((decimal)basicaPulgada * 100) / 100);
                            var medidaConvertida = new Fractional.Fractional((decimal)basicaPulgada, keepExcat: false);
                            var medidaString = medidaConvertida.HumanRepresentation;
                            medidaString=medidaString.Replace("/", "0");
                            medidaString = medidaString.Replace(" ", "0");
                            medidaString = medidaString.PadRight(5,'0');
                            wpry240.MedidaBase = Int32.Parse(medidaString);

                            var wsmy582Basica = await _unitOfWork.WSMY582Repository.GetByProductoMedidaMascara(appDetailQuotes.IdProductoNavigation.ExternalCode, medidaString);
                            if (wsmy582Basica==null)
                            {
                                Wsmy582 newBasica = new Wsmy582();
                                newBasica.Producto = appDetailQuotes.IdProductoNavigation.ExternalCode;
                                newBasica.MedidaMascara = medidaString;
                                newBasica.MedidaFraccion = medidaConvertida.HumanRepresentation;
                                newBasica.Frecuencia = 1;
                                newBasica.MedidaDecimal = medidaConvertida.Value;
                                await _unitOfWork.WSMY582Repository.Add(newBasica);
                                await _unitOfWork.SaveChangesAsync();

                            }

                            var opuesta = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotes.Id, "MEDIDAOPUESTA");
                            var opuestaPulgada = opuesta.Value / (decimal)factorPulgada;
                            opuestaPulgada = (Math.Truncate((decimal)opuestaPulgada * 100) / 100);
                            medidaConvertida = new Fractional.Fractional((decimal)opuestaPulgada, keepExcat: false);
                            medidaString = medidaConvertida.HumanRepresentation;
                            medidaString = medidaString.Replace("/", "0");
                            medidaString = medidaString.Replace(" ", "0");
                            medidaString = medidaString.PadRight(5, '0');
                            wpry240.MedidaOpuesta = Int32.Parse(medidaString);

                            wpry240.LargoCm = (decimal)wpry240.MedidaOpuesta;
                            wpry240.AnchoCm = (decimal)wpry240.MedidaBase;
                            wpry240.IdConstruccion = 3;



                            var wsmy583Basica = await _unitOfWork.WSMY583Repository.GetByProductoMedidaMascara(appDetailQuotes.IdProductoNavigation.ExternalCode, medidaString);
                            if (wsmy583Basica == null)
                            {
                                Wsmy583 newBasica = new Wsmy583();
                                newBasica.Producto = appDetailQuotes.IdProductoNavigation.ExternalCode;
                                newBasica.MedidaMascara = medidaString;
                                newBasica.MedidaFraccion = medidaConvertida.HumanRepresentation;
                                newBasica.MedidaDecimal=medidaConvertida.Value;
                                newBasica.Frecuencia = 1;
                                await _unitOfWork.WSMY583Repository.Add(newBasica);
                                await _unitOfWork.SaveChangesAsync();

                            }



                            _unitOfWork.Wpry240Repository.Update(wpry240);
                            await _unitOfWork.SaveChangesAsync();
                        }
                        else
                        {

                            Wpry240 wpry240new = new Wpry240();
                            wpry240new.Cotizacion = propuesta.Cotizacion;
                            wpry240new.Renglon = propuesta.Renglon;
                            wpry240new.Propuesta = propuesta.Propuesta;
                            wpry240new.IdParte = parte;
                            wpry240new.IdPapel = ingrediente.Code;
                            wpry240new.Cantidad = (decimal)propuesta.Cantidad;
                            wpry240new.FechaRegistro = DateTime.Now;

                            var basica = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotes.Id, "MEDIDABASICA");
                            //Covierte Centimetros a Pulgadas
                            var basicaPulgada = basica.Value / (decimal)factorPulgada;
                            basicaPulgada = (Math.Truncate((decimal)basicaPulgada * 100) / 100);
                            var medidaConvertida = new Fractional.Fractional((decimal)basicaPulgada, keepExcat: false);
                            var medidaString = medidaConvertida.HumanRepresentation;
                            medidaString = medidaString.Replace("/", "0");
                            medidaString = medidaString.Replace(" ", "0");
                            medidaString = medidaString.PadRight(5, '0');
                            wpry240new.MedidaBase = Int32.Parse(medidaString);

                            var opuesta = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesIdCode(appDetailQuotes.Id, "MEDIDAOPUESTA");
                            var opuestaPulgada = opuesta.Value / (decimal)factorPulgada;
                            opuestaPulgada = (Math.Truncate((decimal)opuestaPulgada * 100) / 100);
                            medidaConvertida = new Fractional.Fractional((decimal)opuestaPulgada, keepExcat: false);
                            medidaString = medidaConvertida.HumanRepresentation;
                            medidaString = medidaString.Replace("/", "0");
                            medidaString = medidaString.Replace(" ", "0");
                            medidaString = medidaString.PadRight(5, '0');
                            wpry240new.MedidaOpuesta = Int32.Parse(medidaString);

                            wpry240new.LargoCm = (decimal)wpry240new.MedidaOpuesta;
                            wpry240new.AnchoCm = (decimal)wpry240new.MedidaBase;
                            wpry240new.IdConstruccion = 3;
                            await _unitOfWork.Wpry240Repository.Add(wpry240new);
                            await _unitOfWork.SaveChangesAsync();
                           
                        }


                    }
                }





             



            }



        }

        public async Task UpdateWpry241(AppDetailQuotes appDetailQuotes, int renglon)
        {






            var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(appDetailQuotes.Cotizacion, renglon, 1);
            if (propuesta != null)
            {


              

                string VariableTinta = "TINTA";


                var receta = await _unitOfWork.AppRecipesRepository.GetListRecipesByProductIdVariableCode(appDetailQuotes.IdProducto, VariableTinta);

                if (receta != null)
                {
                    foreach (var itemReceta in receta)
                    {
                        var ingrediente = await _unitOfWork.AppIngredientsRepository.GetById((int)itemReceta.AppIngredientsId);

                        int parte = itemReceta.Secuencia;
                        var idTinta = ingrediente.Code.Trim();

                        var tintas = await _unitOfWork.Wpry241Repository.GetByCotizacionRenglonPropuestaParteTinta(propuesta.Cotizacion, propuesta.Renglon, propuesta.Propuesta, parte,idTinta);
                        if (tintas!=null)
                        {
                            foreach (var item in tintas)
                            {
                                await _unitOfWork.Wpry241Repository.Delete(item.Recnum);
                                await _unitOfWork.SaveChangesAsync();
                            }
                        }

                        Wpry241 wpry241new = new Wpry241();
                        wpry241new.Cotizacion = propuesta.Cotizacion;
                        wpry241new.Renglon = propuesta.Renglon;
                        wpry241new.Propuesta = propuesta.Propuesta;
                        wpry241new.IdParte = parte;
                        wpry241new.IdUbicacion = 1;
                        wpry241new.IdTinta = idTinta;
                        wpry241new.FechaRegistro = DateTime.Now;

                        await _unitOfWork.Wpry241Repository.Add(wpry241new);
                        await _unitOfWork.SaveChangesAsync();

                    }
                }









            }



        }
        public async Task<int> getNextRenglon(string cotizacion)
        {
            int result = 1;


            var renglones = await _unitOfWork.RenglonRepository.GetByCotizacion(cotizacion);
            if (renglones.Count >= 0)
            {
                result = renglones.Count + 1;
            }


            return result;
        }



        public async Task<ValoresCotizacionDto> ValoresCotizacion(AppDetailQuotes appDetailQuotes)
        {
            ValoresCotizacionDto result = new ValoresCotizacionDto();


            var generalQuote = await _unitOfWork.AppGeneralQuotesRepository.GetById(appDetailQuotes.AppGeneralQuotesId);


            short unidadCosteo = 0;
            var csmy036 = await _unitOfWork.Csmy036Repository.GetByCode(appDetailQuotes.IdProductoNavigation.ExternalCode);
            if (csmy036 != null)
            {
                unidadCosteo = (short)csmy036.UnidadCosteo;
            }


            //Actualizacion de variables externas en ecotizador
            result.PrecioUnitarioExterno = appDetailQuotes.Precio;
            result.TotalPropuestaExterno = appDetailQuotes.Total;
            result.PrecioUnitarioUsdExterno = appDetailQuotes.PrecioUsd;
            result.TotalPropuestaUsdExterno = appDetailQuotes.TotalUsd;
            result.CantidadExterno = appDetailQuotes.Cantidad;
            result.IdUnidadExterna = appDetailQuotes.IdUnidad;
            result.CodeUnidadExterna = appDetailQuotes.IdUnidadNavigation.Code;
            result.DescripcionUnidadExterna = appDetailQuotes.IdUnidadNavigation.Description1;
            result.ValorConvertidoExterno = appDetailQuotes.ValorConvertido;
            result.CantidadPorUnidadProduccion = (1 / appDetailQuotes.ValorConvertido);
            result.CantidadSolicitadaExterna = appDetailQuotes.CantidadSolicitada;


            result.IdUnidadPrecio = appDetailQuotes.IdProductoNavigation.ProductionUnitId;
            var unidaProduccion = await _unitOfWork.AppUnitsRepository.GetById((int)appDetailQuotes.IdProductoNavigation.ProductionUnitId);

            result.CodeUnidaPrecio = unidaProduccion.Code;



            if (appDetailQuotes.IdProductoNavigation.ProductionUnitId== appDetailQuotes.IdUnidad)
            {
                var valor = (1 / appDetailQuotes.ValorConvertido) * appDetailQuotes.Cantidad;
                result.Cantidad = Math.Truncate(valor);

            }
            else
            {
                result.Cantidad = appDetailQuotes.CantidadSolicitada;
            }



          
            result.CantFormas = result.Cantidad;
            result.CantMill = (float)((decimal)result.Cantidad / (decimal)unidadCosteo);


            decimal precioUsdUnidadSolicitada = 0;
            decimal precioUnidadSolicitada = 0;

            decimal precioUsdMillarSolicitada = 0;
            decimal precioMillarSolicitada = 0;

            
            precioUsdUnidadSolicitada = appDetailQuotes.TotalUsd /(decimal)result.Cantidad ;
            precioUsdMillarSolicitada = unidadCosteo * precioUsdUnidadSolicitada;
            result.PrecioUnitarioUsd = precioUsdMillarSolicitada;
            result.TotalPropuestaUsd = appDetailQuotes.TotalUsd;


            precioUnidadSolicitada = appDetailQuotes.Total / (decimal)result.Cantidad ;
            precioMillarSolicitada = unidadCosteo * precioUnidadSolicitada;
            result.PrecioUnitario = precioMillarSolicitada;
            result.TotalPropuesta = appDetailQuotes.Total;

           

            return result;
        }


        //Delete datos Cotizacion

        public async Task DeleteWpry229ByCotizacion(AppDetailQuotes appDetailQuotes)
        {

            var wpry229 = await _unitOfWork.Wpry229Repository.GetByCotizacion(appDetailQuotes.Cotizacion);

            if (wpry229 != null)
            {
                foreach (var item in wpry229)
                {
                    await _unitOfWork.Wpry229Repository.Delete(item.IdSolicitud);
                    await _unitOfWork.SaveChangesAsync();
                }
            }




        }

        public async Task DeleteWpry240ByCotizacion(AppDetailQuotes appDetailQuotes)
        {

            var wpry240 = await _unitOfWork.Wpry240Repository.GetByCotizacion(appDetailQuotes.Cotizacion);

            if (wpry240!=null)
            {
                foreach (var item in wpry240)
                {
                    await _unitOfWork.Wpry240Repository.Delete(item.Cotizacion, item.Renglon, item.Propuesta, item.IdParte);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
     



        }

        public async Task DeleteWpry241ByCotizacion(AppDetailQuotes appDetailQuotes)
        {


            var tintas = await _unitOfWork.Wpry241Repository.GetByCotizacion(appDetailQuotes.Cotizacion);
            if (tintas != null)
            {
                foreach (var item in tintas)
                {
                    await _unitOfWork.Wpry241Repository.Delete(item.Recnum);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
        }

        public async Task DeletePropuestaCotizacion(AppDetailQuotes appDetailQuotes, int renglon)
        {
          


            var propuesta = await _unitOfWork.PropuestaRepository.GetByCotizacionRenglonPropuesta(appDetailQuotes.Cotizacion, renglon, 1);
            if (propuesta != null)
            {


              
                await _unitOfWork.PropuestaRepository.Delete(appDetailQuotes.Cotizacion, renglon, 1);
                await _unitOfWork.SaveChangesAsync();
            }
         

        }
        public async Task DeleteRenglonCotizacion(AppDetailQuotes appDetailQuotes, int renglon)
        {



            var renglonObj = await _unitOfWork.RenglonRepository.GetByCotizacionRenglon(appDetailQuotes.Cotizacion, renglon);
            if (renglonObj != null)
            {



                await _unitOfWork.RenglonRepository.Delete(appDetailQuotes.Cotizacion, renglon);
                await _unitOfWork.SaveChangesAsync();
            }


        }

        public async Task DeleteCotizacion(AppGeneralQuotes appGeneralQuotes)
        {


            var cotizailoList = await _unitOfWork.CotizacionRepository.GetByCotizacion(appGeneralQuotes.Cotizacion);
            if (cotizailoList!=null)
            {

                var detailQuotesList = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotes.Id);
                if (detailQuotesList!=null && detailQuotesList.Count>0)
                {
                    foreach (var item in detailQuotesList)
                    {
                        var renglonObj = await _unitOfWork.RenglonRepository.GetByCotizacionProducto(item.Cotizacion, item.IdProductoNavigation.ExternalCode);
                        if (renglonObj!=null)
                        {
                           await DeleteWpry229ByCotizacion(item);
                           await DeleteWpry240ByCotizacion(item);
                           await DeleteWpry241ByCotizacion(item);
                           await DeletePropuestaCotizacion(item, renglonObj.Renglon);
                           await DeleteRenglonCotizacion(item, renglonObj.Renglon);


                        }

                        
                    }
                }




                await _unitOfWork.CotizacionRepository.Delete(appGeneralQuotes.Cotizacion);
                await _unitOfWork.SaveChangesAsync();

            }
          


        }


        public async Task DeleteCotizacionRenglon(AppDetailQuotes appDetailQuotes)
        {



                        var renglonObj = await _unitOfWork.RenglonRepository.GetByCotizacionProducto(appDetailQuotes.Cotizacion, appDetailQuotes.IdProductoNavigation.ExternalCode);
                        if (renglonObj != null)
                        {
                            await DeleteWpry229ByCotizacion(appDetailQuotes);
                            await DeleteWpry240ByCotizacion(appDetailQuotes);
                            await DeleteWpry241ByCotizacion(appDetailQuotes);
                            await DeletePropuestaCotizacion(appDetailQuotes, renglonObj.Renglon);
                            await DeleteRenglonCotizacion(appDetailQuotes, renglonObj.Renglon);


                        }


   





            



        }


        public async Task updateMedidas()
        {

            var wsmy582Basica = await _unitOfWork.WSMY582Repository.GetAll();
            if (wsmy582Basica!= null)
            {

                foreach (var item in wsmy582Basica)
                {
                    var medidaConvertida = new Fractional.Fractional(item.MedidaFraccion);

                    item.MedidaDecimal = medidaConvertida.Value;

                    _unitOfWork.WSMY582Repository.Update(item);
                    await _unitOfWork.SaveChangesAsync();
                }

            }



            var wsmy583Basica = await _unitOfWork.WSMY583Repository.GetAll();
            if (wsmy583Basica != null)
            {

                foreach (var item in wsmy583Basica)
                {
                    var medidaConvertida = new Fractional.Fractional(item.MedidaFraccion);

                    item.MedidaDecimal = medidaConvertida.Value;

                    _unitOfWork.WSMY583Repository.Update(item);
                    await _unitOfWork.SaveChangesAsync();
                }

            }

        }


    }
}
