using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppGeneralQuotesService : IAppGeneralQuotesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOfdCotizacionService _ofdCotizacionService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly IAppDetailQuotesService _appDetailQuotesService;
        private readonly ICotizacionService _cotizacionService;
        private readonly PaginationOptions _paginationOptions;

        public AppGeneralQuotesService(IUnitOfWork unitOfWork,
                                       IOptions<PaginationOptions> options,
                                        IMapper mapper,
                                        IOfdCotizacionService ofdCotizacionService,
                                        IMtrClienteService mtrClienteService,
                                        IAppDetailQuotesService appDetailQuotesService,
                                        ICotizacionService   cotizacionService
                                        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ofdCotizacionService = ofdCotizacionService;
            _mtrClienteService = mtrClienteService;
            _appDetailQuotesService = appDetailQuotesService;
            _cotizacionService = cotizacionService;
            _paginationOptions = options.Value;
        }

        public async Task<AppGeneralQuotes> GetById(int id)
        {
            return await _unitOfWork.AppGeneralQuotesRepository.GetById(id);
        }


        public async Task<AppGeneralQuotesGetDto> GetAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {





            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            AppGeneralQuotes quotes = await _unitOfWork.AppGeneralQuotesRepository.GetByCotizacions(filters.Cotizacion);
            if (quotes != null)
            {
                AppGeneralQuotesGetDto appGeneralQuotesGetDto = _mapper.Map<AppGeneralQuotesGetDto>(quotes);

                MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotesGetDto.IdVendedor);
                if (mtrVendedor != null)
                {
                    MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                    appGeneralQuotesGetDto.MtrVendedorDto = mtrVendedorDto;
                }



                MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(appGeneralQuotesGetDto.IdCliente);
                if (mtrCliente != null)
                {
                    MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                    appGeneralQuotesGetDto.MtrClienteDto = mtrClienteDto;


                }

                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesGetDto.IdContacto);
                if (mtrContactos != null)
                {

                    //MtrContactosDto mtrContactosDto = new MtrContactosDto();
                    //mtrContactosDto.IdContacto = mtrContactos.IdContacto;
                    //mtrContactosDto.Cargo = mtrContactos.Email;

                    MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                    appGeneralQuotesGetDto.MtrContactosDto = mtrContactosDto;
                }



                MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesGetDto.IdDireccionEntregar);
                if (direccionEntregar != null)
                {
                    MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                    appGeneralQuotesGetDto.MtrDireccionesEntregarDto = direccionEntregarDto;
                }



                MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesGetDto.IdDireccionFacturar);
                if (direccionFacturar != null)
                {
                    MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                    appGeneralQuotesGetDto.MtrDireccionesFacturarDto = direccionFacturarDto;

                }

                MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesGetDto.IdCondPago);
                if (condicionPago != null)
                {
                    CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                    appGeneralQuotesGetDto.CondicionPagoDto = condicionPagoDto;

                }

                MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesGetDto.IdMtrTipoMoneda);
                if (mtrTipoMoneda != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                    appGeneralQuotesGetDto.MtrTipoMonedaDto = mtrTipoMonedaDto;

                }

                var actualizar = await _unitOfWork.AppGeneralQuotesRepository.VerificarStatus(appGeneralQuotesGetDto.Id);
                if (actualizar)
                {
                    await _unitOfWork.SaveChangesAsync();
                }
                

                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotesGetDto.IdEstatus);
                if (appStatusQuote != null)
                {
                    AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                    appGeneralQuotesGetDto.AppStatusQuoteGetDto = appStatusQuoteDto;

                }

                appGeneralQuotesGetDto.PorcFlete = await GetFleteByIdDireccionEntrega(appGeneralQuotesGetDto.IdDireccionEntregar);


                var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(appGeneralQuotesGetDto.Id);
                appGeneralQuotesGetDto.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                appGeneralQuotesGetDto.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(appGeneralQuotesGetDto.Id);

                ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(appGeneralQuotesGetDto.Id);
                if (listDetail != null)
                {
                    appGeneralQuotesGetDto.AppDetailQuotesGetDto = listDetail.Data;
                }




                return appGeneralQuotesGetDto;
            }
            else
            {
                return null;
            }





        }

        public async Task<PagedList<AppGeneralQuotesGetDto>> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {





            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;


            List<AppGeneralQuotes> quotes = await _unitOfWork.AppGeneralQuotesRepository.GetAll(filters);
            if (quotes.Count > 0)
            {
                List<AppGeneralQuotesGetDto> appGeneralQuotesGetDto = _mapper.Map<List<AppGeneralQuotesGetDto>>(quotes);
                foreach (AppGeneralQuotesGetDto item in appGeneralQuotesGetDto)
                {

                    
                    MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(item.IdVendedor);
                    if (mtrVendedor != null)
                    {
                        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                        item.MtrVendedorDto = mtrVendedorDto;
                    }



                    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(item.IdCliente);
                    if (mtrCliente != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                        item.MtrClienteDto = mtrClienteDto;
                        if (item.IdCliente=="000000")
                        {
                            item.MtrClienteDto.Descripcion = item.IdCliente.Trim() + "-" + item.RazonSocial.Trim() + " RIF: " + item.Rif.ToString();
                           
                        }

                    }

                    MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(item.IdContacto);
                    if (mtrContactos != null)
                    {

                        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                        item.MtrContactosDto = mtrContactosDto;
                    }



                    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionEntregar);
                    if (direccionEntregar != null)
                    {
                        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                        item.MtrDireccionesEntregarDto = direccionEntregarDto;
                    }



                    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(item.IdDireccionFacturar);
                    if (direccionFacturar != null)
                    {
                        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                        item.MtrDireccionesFacturarDto = direccionFacturarDto;

                    }

                    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(item.IdCondPago);
                    if (condicionPago != null)
                    {
                        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                        item.CondicionPagoDto = condicionPagoDto;

                    }

                    MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(item.IdMtrTipoMoneda);
                    if (mtrTipoMoneda != null)
                    {
                        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                        item.MtrTipoMonedaDto = mtrTipoMonedaDto;

                    }

                    var actualizar = await _unitOfWork.AppGeneralQuotesRepository.VerificarStatus(item.Id);
                    if (actualizar)
                    {
                        await _unitOfWork.SaveChangesAsync();
                    }
                    

                    AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(item.IdEstatus);
                    if (appStatusQuote != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteDto = _mapper.Map<AppStatusQuoteGetDto>(appStatusQuote);
                        item.AppStatusQuoteGetDto = appStatusQuoteDto;

                    }

                    if (item.IdCliente == "000000")
                    {
                        
                        var municipio = await _unitOfWork.Winy243Repository.GetById(item.IdMunicipio);
                        if (municipio!=null)
                        {
                            item.PorcFlete = municipio.PorcFlete;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            item.MunicipioGetDto = municipioGetDto;
                        }

                    }
                    else
                    {
                        item.PorcFlete = await GetFleteByIdDireccionEntrega(item.IdDireccionEntregar);
                        var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregar.Estado, direccionEntregar.Municipio);
                        if (municipio != null)
                        {
                            item.IdMunicipio = municipio.Recnum;
                            item.descripcionMunicipio = municipio.DescMunicipio;
                            MunicipioGetDto municipioGetDto = _mapper.Map<MunicipioGetDto>(municipio);
                            item.MunicipioGetDto = municipioGetDto;
                        }
                    }



                    var permiteAdicionarDetalle = await _unitOfWork.AppGeneralQuotesRepository.PermiteAdicionarDetalle(item.Id);
                    item.PermiteAdicionarDetalle = permiteAdicionarDetalle;

                    item.AppGeneralQuotesActionSheetDto = await GetAppGeneralQuotesActionSheetDto(item.Id);


                    ApiResponse<List<AppDetailQuotesGetDto>> listDetail = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(item.Id);
                    if (listDetail != null)
                    {
                        item.AppDetailQuotesGetDto = listDetail.Data;
                    }

                    item.FechaString = item.Fecha.ToString("dd/MM/yyyy");
                }

                PagedList<AppGeneralQuotesGetDto> pagedResult = PagedList<AppGeneralQuotesGetDto>.Create(appGeneralQuotesGetDto, filters.PageNumber, filters.PageSize);



                return pagedResult;
            }
            else
            {
                return null;
            }





        }

        public async Task<AppGeneralQuotes> Insert(AppGeneralQuotes appGeneralQuotes)
        {

            await _unitOfWork.AppGeneralQuotesRepository.Add(appGeneralQuotes);
       
            await _unitOfWork.SaveChangesAsync();
            return appGeneralQuotes;
        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> InsertGeneralQuotes(AppGeneralQuotesCreateDto appGeneralQuotesCreateDto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);

            try
            {

                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(appGeneralQuotesCreateDto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente No Existe!!! " + appGeneralQuotesCreateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                MtrDirecciones direccionEntregarValidate = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesCreateDto.IdDireccionEntregar);
                if (direccionEntregarValidate == null && appGeneralQuotesCreateDto.IdCliente!= "000000")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Direccion Entregar No Existe!!! " + appGeneralQuotesCreateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                MtrContactos mtrContactosValidate = await _unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesCreateDto.IdContacto);
                if (mtrContactosValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                MtrCondicionPago condicionPagoValidate = await _unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesCreateDto.IdCondPago);
                if (condicionPagoValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Condicion de Pago No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                MtrTipoMoneda mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesCreateDto.IdMtrTipoMoneda);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appGeneralQuotesCreateDto.OrdenCompra.Length > 16)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Longitud Maxima de Orden de Compra es 16 !!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                appGeneralQuotesCreateDto.Fecha = DateTime.Now;

                if (appGeneralQuotesCreateDto.IdCliente != "000000")
                {
  
                        appGeneralQuotesCreateDto.Rif = cliente.NoRegTribut;
                        appGeneralQuotesCreateDto.RazonSocial = cliente.Nombre;
                        appGeneralQuotesCreateDto.Direccion = cliente.Direccion+" " +  cliente.Direccion1;

                }


                AppGeneralQuotes appGeneralQuotes = _mapper.Map<AppGeneralQuotes>(appGeneralQuotesCreateDto);

                if (appGeneralQuotesCreateDto.IdCliente != "000000")
                {
                    appGeneralQuotes.IdVendedor = cliente.Vendedor1.Trim();
                }
                else
                {
                    appGeneralQuotes.IdVendedor = appGeneralQuotesCreateDto.UsuarioActualiza;
                }


                if (appGeneralQuotesCreateDto.IdCliente == "000000")
                {
                    appGeneralQuotes.IdMunicipio = appGeneralQuotesCreateDto.IdMunicipio;
                    var municipio = await _unitOfWork.Winy243Repository.GetById(appGeneralQuotesCreateDto.IdMunicipio);
                    if (municipio != null)
                    {
                        appGeneralQuotes.DescripcionMunicipio = municipio.DescMunicipio;
                    }

                }
                else
                {
                    var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregarValidate.Estado, direccionEntregarValidate.Municipio);
                    if (municipio != null)
                    {
                        appGeneralQuotes.IdMunicipio = municipio.Recnum;
                        appGeneralQuotes.DescripcionMunicipio = municipio.DescMunicipio;
                    }


                }

                appGeneralQuotes.Cotizacion = _unitOfWork.CotizacionRepository.ProximaCotizacion(appGeneralQuotes.IdVendedor);
                appGeneralQuotes.IdEstatus = 1;
                appGeneralQuotes.CreatedAt = DateTime.Now;
                appGeneralQuotes.FechaActualiza = DateTime.Now;
                appGeneralQuotes.FechaCaducidad = DateTime.Now.AddDays(1);
                appGeneralQuotes.DiasVigencia = 1;
                appGeneralQuotes.ObservacionPostergar = "";
                appGeneralQuotes.IdDireccionFacturar = (decimal)cliente.IdDireccion;
                appGeneralQuotes.UsuarioActualiza = appGeneralQuotesCreateDto.UsuarioActualiza;
                appGeneralQuotes.UserCreate = appGeneralQuotesCreateDto.UsuarioActualiza;
                appGeneralQuotes.Proximo = 0;
                appGeneralQuotes.FijarPrecioBs = appGeneralQuotesCreateDto.FijarPrecioBs;
                if (appGeneralQuotes.ObservacionPostergar==null)
                {
                    appGeneralQuotes.ObservacionPostergar = "";
                }

                AppStatusQuote appStatusQuote =await  _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);


                MtrVendedor vendedor = _unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotes.IdVendedor);

                if (appGeneralQuotesCreateDto.IdCliente != "000000")
                {

                    appGeneralQuotes.SearchText = $"{appGeneralQuotes.Cotizacion}-{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appGeneralQuotes.IdCliente}-{cliente.Nombre.Trim()}-{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appGeneralQuotes.IdCliente}-{appGeneralQuotes.RazonSocial.Trim()}-{appStatusQuote.Descripcion.Trim()}";


                }
                else
                {
                    appGeneralQuotes.SearchText = $"{appGeneralQuotes.Cotizacion}-{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appStatusQuote.Descripcion.Trim()}";
                    appGeneralQuotes.IdDireccionEntregar = 1;
                    appGeneralQuotes.IdDireccionFacturar = 1;

                }

                AppGeneralQuotes AppGeneralQuotesInserted = await Insert(appGeneralQuotes);

                await _cotizacionService.IntegrarCotizacion(AppGeneralQuotesInserted.Id);

                if (AppGeneralQuotesInserted != null)
                {
                    resultDto = _mapper.Map<AppGeneralQuotesGetDto>(AppGeneralQuotesInserted);

                    MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(resultDto.IdVendedor);
                    if (mtrVendedor != null)
                    {
                        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                        resultDto.MtrVendedorDto = mtrVendedorDto;
                    }



                    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(resultDto.IdCliente);
                    if (mtrCliente != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                        resultDto.MtrClienteDto = mtrClienteDto;


                    }

                    MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(resultDto.IdContacto);
                    if (mtrContactos != null)
                    {


                        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                        resultDto.MtrContactosDto = mtrContactosDto;
                    }



                    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionEntregar);
                    if (direccionEntregar != null)
                    {
                        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                        resultDto.MtrDireccionesEntregarDto = direccionEntregarDto;
                    }



                    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionFacturar);
                    if (direccionFacturar != null)
                    {
                        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                        resultDto.MtrDireccionesFacturarDto = direccionFacturarDto;

                    }

                    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(resultDto.IdCondPago);
                    if (condicionPago != null)
                    {
                        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                        resultDto.CondicionPagoDto = condicionPagoDto;

                    }

                    MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(resultDto.IdMtrTipoMoneda);
                    if (mtrTipoMoneda != null)
                    {
                        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                        resultDto.MtrTipoMonedaDto = mtrTipoMonedaDto;

                    }


                    metadata.IsValid = true;
                    metadata.Message = $"Cotizacion: {resultDto.Cotizacion} creada Satisfactoriamente!!";

                }
                else
                {
                    metadata.IsValid = false;

                    metadata.Message = "Registro No actualizado";

                }


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

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> UpdateGeneralQuotes(AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);

            try
            {

                AppGeneralQuotes appGeneralQuotes = await GetById(appGeneralQuotesUpdateDto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! " + appGeneralQuotesUpdateDto.Cotizacion;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(appGeneralQuotesUpdateDto.IdCliente);
                if (cliente == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cliente No Existe!!! " + appGeneralQuotesUpdateDto.IdCliente;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
                MtrDirecciones direccionEntregarValidate = await _unitOfWork.MtrDireccionesRepository.GetById(appGeneralQuotesUpdateDto.IdDireccionEntregar);
                if (direccionEntregarValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Direccion Entregar No Existe!!! " + appGeneralQuotesUpdateDto.IdDireccionEntregar;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                MtrContactos mtrContactosValidate = await _unitOfWork.MtrContactosRepository.GetById(appGeneralQuotesUpdateDto.IdContacto);
                if (mtrContactosValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                MtrCondicionPago condicionPagoValidate = await _unitOfWork.MtrCondicionPagoRepository.GetById(appGeneralQuotesUpdateDto.IdCondPago);
                if (condicionPagoValidate == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Condicion de Pago No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                MtrTipoMoneda mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById(appGeneralQuotesUpdateDto.IdMtrTipoMoneda);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appGeneralQuotesUpdateDto.OrdenCompra.Length > 16)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Longitud Maxima de Orden de Compra es 16 !!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                if (appGeneralQuotesUpdateDto.IdCliente != "000000")
                {

                    appGeneralQuotesUpdateDto.Rif = cliente.NoRegTribut;
                    appGeneralQuotesUpdateDto.RazonSocial = cliente.Nombre;
                    appGeneralQuotesUpdateDto.Direccion = cliente.Direccion + " " + cliente.Direccion1;

                }
                appGeneralQuotes.Rif = appGeneralQuotesUpdateDto.Rif;
                appGeneralQuotes.RazonSocial = appGeneralQuotesUpdateDto.RazonSocial;
                appGeneralQuotes.Direccion = appGeneralQuotesUpdateDto.Direccion;

                appGeneralQuotes.IdCliente = appGeneralQuotesUpdateDto.IdCliente;

                if (appGeneralQuotesUpdateDto.IdCliente == "000000")
                {
                    appGeneralQuotes.IdMunicipio = appGeneralQuotesUpdateDto.IdMunicipio;
                    var municipio= await _unitOfWork.Winy243Repository.GetById(appGeneralQuotesUpdateDto.IdMunicipio);
                    if (municipio!=null)
                    {
                        appGeneralQuotes.DescripcionMunicipio = municipio.DescMunicipio;
                    }

                }
                else
                {
                    var municipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccionEntregarValidate.Estado, direccionEntregarValidate.Municipio);
                    if (municipio != null)
                    {
                        appGeneralQuotes.IdMunicipio = municipio.Recnum;
                        appGeneralQuotes.DescripcionMunicipio = municipio.DescMunicipio;
                    }


                }

                

                if (appGeneralQuotesUpdateDto.IdCliente != "000000")
                {
                    appGeneralQuotes.IdVendedor = cliente.Vendedor1.Trim();
                }
                else
                {
                    appGeneralQuotes.IdVendedor = appGeneralQuotesUpdateDto.UsuarioActualiza;
                }
              

                appGeneralQuotes.Observaciones = appGeneralQuotesUpdateDto.Observaciones;
                appGeneralQuotes.IdCondPago = appGeneralQuotesUpdateDto.IdCondPago;
                appGeneralQuotes.IdContacto = appGeneralQuotesUpdateDto.IdContacto;
                appGeneralQuotes.IdDireccionFacturar = (decimal)cliente.IdDireccion;
                appGeneralQuotes.IdDireccionEntregar = appGeneralQuotesUpdateDto.IdDireccionEntregar;
                appGeneralQuotes.OrdenCompra = appGeneralQuotesUpdateDto.OrdenCompra;
                appGeneralQuotes.UsuarioActualiza = appGeneralQuotesUpdateDto.UsuarioActualiza;
                appGeneralQuotes.FechaActualiza = DateTime.Now;
                appGeneralQuotes.Proximo = 0;
                appGeneralQuotes.IdMtrTipoMoneda = appGeneralQuotesUpdateDto.IdMtrTipoMoneda;
                if (appGeneralQuotesUpdateDto.FechaPostergada != null)
                {
                    appGeneralQuotes.FechaPostergada = appGeneralQuotesUpdateDto.FechaPostergada;
                }
                if (appGeneralQuotesUpdateDto.ObservacionPostergar != "" && appGeneralQuotesUpdateDto.ObservacionPostergar !=null)
                {
                    appGeneralQuotes.ObservacionPostergar = appGeneralQuotesUpdateDto.ObservacionPostergar;
                }
                else
                {
                    appGeneralQuotesUpdateDto.ObservacionPostergar = "";

                }
                appGeneralQuotes.FijarPrecioBs = appGeneralQuotesUpdateDto.FijarPrecioBs;


                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);

                MtrVendedor vendedor = _unitOfWork.MtrVendedorRepository.GetById(appGeneralQuotes.IdVendedor);



                if (appGeneralQuotesUpdateDto.IdCliente != "000000")
                {

                    appGeneralQuotes.SearchText = $"{appGeneralQuotes.Cotizacion}-{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appGeneralQuotes.IdCliente}-{cliente.Nombre.Trim()}{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appGeneralQuotes.IdCliente}-{appGeneralQuotes.RazonSocial.Trim()}-{appStatusQuote.Descripcion.Trim()}";


                }
                else
                {
                    appGeneralQuotes.SearchText = $"{appGeneralQuotes.Cotizacion}-{appGeneralQuotes.IdVendedor}-{vendedor.Nombre.Trim()}-{appGeneralQuotes.IdCliente}-{appGeneralQuotes.RazonSocial.Trim()}-{appStatusQuote.Descripcion.Trim()}";
                    appGeneralQuotes.IdDireccionEntregar = 1;
                    appGeneralQuotes.IdDireccionFacturar = 1;

                }




                AppGeneralQuotes AppGeneralQuotesUpdated = await Update(appGeneralQuotes);

                //await _cotizacionService.IntegrarCotizacion(AppGeneralQuotesUpdated.Id);
                


                if (AppGeneralQuotesUpdated != null)
                {
                    resultDto = _mapper.Map<AppGeneralQuotesGetDto>(AppGeneralQuotesUpdated);

                    MtrVendedor mtrVendedor = _unitOfWork.MtrVendedorRepository.GetById(resultDto.IdVendedor);
                    if (mtrVendedor != null)
                    {
                        MtrVendedorDto mtrVendedorDto = _mapper.Map<MtrVendedorDto>(mtrVendedor);
                        resultDto.MtrVendedorDto = mtrVendedorDto;
                    }



                    MtrCliente mtrCliente = _unitOfWork.MtrClienteRepository.GetById(resultDto.IdCliente);
                    if (mtrCliente != null)
                    {
                        MtrClienteDto mtrClienteDto = _mapper.Map<MtrClienteDto>(mtrCliente);
                        resultDto.MtrClienteDto = mtrClienteDto;


                    }

                    MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById(resultDto.IdContacto);
                    if (mtrContactos != null)
                    {


                        MtrContactosDto mtrContactosDto = _mapper.Map<MtrContactosDto>(mtrContactos);
                        resultDto.MtrContactosDto = mtrContactosDto;
                    }



                    MtrDirecciones direccionEntregar = await _unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionEntregar);
                    if (direccionEntregar != null)
                    {
                        MtrDireccionesDto direccionEntregarDto = _mapper.Map<MtrDireccionesDto>(direccionEntregar);
                        resultDto.MtrDireccionesEntregarDto = direccionEntregarDto;
                    }



                    MtrDirecciones direccionFacturar = await _unitOfWork.MtrDireccionesRepository.GetById(resultDto.IdDireccionFacturar);
                    if (direccionFacturar != null)
                    {
                        MtrDireccionesDto direccionFacturarDto = _mapper.Map<MtrDireccionesDto>(direccionFacturar);
                        resultDto.MtrDireccionesFacturarDto = direccionFacturarDto;

                    }

                    MtrCondicionPago condicionPago = await _unitOfWork.MtrCondicionPagoRepository.GetById(resultDto.IdCondPago);
                    if (condicionPago != null)
                    {
                        CondicionPagoDto condicionPagoDto = _mapper.Map<CondicionPagoDto>(condicionPago);
                        resultDto.CondicionPagoDto = condicionPagoDto;

                    }


                    MtrTipoMoneda mtrTipoMoneda = await _unitOfWork.MtrTipoMonedaRepository.GetById(resultDto.IdMtrTipoMoneda);
                    if (mtrTipoMoneda != null)
                    {
                        MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(mtrTipoMoneda);
                        resultDto.MtrTipoMonedaDto = mtrTipoMonedaDto;

                    }

                    metadata.IsValid = true;
                    metadata.Message = $"Cotizacion: {resultDto.Cotizacion} Actualizada Satisfactoriamente!!";

                }
                else
                {
                    metadata.IsValid = false;

                    metadata.Message = "Registro No actualizado";

                }


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

        public async Task<ApiResponse<bool>> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto)
        {
            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);

            try
            {

                AppGeneralQuotes appGeneralQuotes = await GetById(appGeneralQuotesDeleteDto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! " + appGeneralQuotesDeleteDto.Cotizacion;
                    response.Meta = metadata;
                    response.Data = false;
                    return response;
                }

                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(appGeneralQuotes.IdEstatus);
                if (appStatusQuote.FlagModificar=="X")
                {

                    await _cotizacionService.DeleteCotizacion(appGeneralQuotes);

                    var detail = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotes.Id);
                    if (detail!=null && detail.Count>0)
                    {
                        foreach (var item in detail)
                        {

                            var detailConversion = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(item.Id);
                            if (detailConversion != null && detailConversion.Count > 0)
                            {
                                foreach (var itemConversion in detailConversion)
                                {
                                    await _unitOfWork.AppDetailQuotesConversionUnitRepository.Delete(itemConversion.Id);
                                    await _unitOfWork.SaveChangesAsync();
                                }
                            }


                            await _unitOfWork.AppDetailQuotesRepository.Delete(item.Id);
                            await _unitOfWork.SaveChangesAsync();
                        }
                    }
                    await Delete(appGeneralQuotesDeleteDto.Id);


                }
                
                

                metadata.IsValid = true;
                metadata.Message = $"Cotizacion: {appGeneralQuotesDeleteDto.Cotizacion} Eliminada Satisfactoriamente!!";

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


        public async Task<AppGeneralQuotes> Update(AppGeneralQuotes appGeneralQuotes)
        {

            _unitOfWork.AppGeneralQuotesRepository.Update(appGeneralQuotes);
            await _unitOfWork.SaveChangesAsync();


            return await GetById(appGeneralQuotes.Id);

        }

        public async Task Delete(int id)
        {

            await _unitOfWork.AppGeneralQuotesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }


        public string ProximaCotizacion(string Cod_Vendedor)
        {

            string proximaCotizacion = _unitOfWork.AppGeneralQuotesRepository.ProximaCotizacion(Cod_Vendedor);


            return proximaCotizacion;

        }

        public async Task<ApiResponse<AppGeneralQuotesGetDto>> EnviarAlCliente(AppGeneralQuotesChangeStatusDto dto)
        {
            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);

            try
            {

                AppGeneralQuotes appGeneralQuotes = await GetById(dto.Id);
                if (appGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                if (appGeneralQuotes.IdEstatus != 1)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No esta en grabacion!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }




                ApiResponse<List<AppDetailQuotesGetDto>> appDatailQuotes = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(dto.Id);
                if (appDatailQuotes.Data.Count > 0)
                {

                    foreach (AppDetailQuotesGetDto item in appDatailQuotes.Data)
                    {

                        AppDetailQuotes detailQuotes = await _appDetailQuotesService.GetById(item.Id);
                        if (detailQuotes != null)
                        {

                            if (detailQuotes.PrecioUsd< detailQuotes.UnitPriceConverted)
                            {
                                metadata.IsValid = false;
                                metadata.Message = "Precio de Venta es menor a la Lista..Enviar a Aprobacion!!! ";
                                response.Meta = metadata;
                                response.Data = resultDto;
                                return response;
                            }

                            detailQuotes.IdEstatus = 2;
                            await _appDetailQuotesService.Update(detailQuotes);
                        }


                    }

                    appGeneralQuotes.IdEstatus = 2;

                    AppGeneralQuotes AppGeneralQuotesUpdated = await Update(appGeneralQuotes);


                    await _cotizacionService.IntegrarCotizacion(appGeneralQuotes.Id);

                    AppGeneralQuotesQueryFilter filters = new AppGeneralQuotesQueryFilter
                    {
                        Cotizacion = appGeneralQuotes.Cotizacion
                    };

                    resultDto = await GetAppGeneralQuotes(filters);

                    metadata.IsValid = true;
                    metadata.Message = "Cotizacion Enviada al cliente!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;

                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No tiene Productos cargados!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }







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



        public async Task<AppGeneralQuotesActionSheetDto> GetAppGeneralQuotesActionSheetDto(int AppGeneralQuotesId)
        {




            AppGeneralQuotesActionSheetDto resultDto = new AppGeneralQuotesActionSheetDto();
          
                
               
            resultDto.Cancel = true;
               
       


            AppGeneralQuotes generalQuotes = await GetById(AppGeneralQuotesId);

            if (generalQuotes != null)
            {
                resultDto.ExistQuotes = true;

                AppStatusQuote appStatusQuote = await _unitOfWork.AppStatusQuoteRepository.GetById(generalQuotes.IdEstatus);
               


                if (appStatusQuote.FlagModificar=="X")
                {
                    resultDto.Actualizar = true;
                    resultDto.Eliminar = true;
                }
                else
                {
                    resultDto.Actualizar = false;
                    resultDto.Eliminar = false;
                }


                var requiereAprobacion = await _appDetailQuotesService.RequiereAprobacionAppGeneralQuotesId(generalQuotes.Id);
                if (appStatusQuote.PrimeraEstacion == "X")
                {


                   
                    if (requiereAprobacion)
                    {
                        resultDto.EnviarAlCliente = false;
                    }
                    else
                    {
                        resultDto.EnviarAlCliente = true;

                    }

                }
                else
                {
                    resultDto.EnviarAlCliente = false;
                }

                
                resultDto.EnviarAprobacionPrecio = false;
              


                var existe = await _unitOfWork.AppDetailQuotesRepository.ExisteEnEspera(AppGeneralQuotesId);

                resultDto.GanarPerder = existe;


                if (!requiereAprobacion)
                {
                    resultDto.Imprimir = true;

                }



            }
            else
            {
                resultDto.ExistQuotes = false;
            }


            return resultDto;

        }

       public async Task<decimal>  GetFleteByIdDireccionEntrega(decimal id)
        {
            decimal result = 0;

            var direccion = await _unitOfWork.MtrDireccionesRepository.GetById(id);

            if (direccion!=null)
            {
                var estadoMunicipio = await _unitOfWork.Winy243Repository.GetByEstadoMunicipio(direccion.Estado, direccion.Municipio);
                if (estadoMunicipio!=null)
                {
                    result = (decimal)estadoMunicipio.PorcFlete;

                }
                else
                {
                    result = 0;
                }
            }
            else
            {
                result = 0;
            }


            return result;


        }
      


        }
    
}
