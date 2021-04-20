using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppDetailQuotesService: IAppDetailQuotesService
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppProductsService _appProductsService;
        private readonly IAppUnitsService _appUnitsService;
        private readonly IAppStatusQuoteService _appStatusQuoteService;
        private readonly ITPaTasaReferencialServices _tPaTasaReferencialServices;
        private readonly IAppDetailQuotesConversionUnitService _appDetailQuotesConversionUnitService;
        private readonly IAppTemplateConversionUnitService _appTemplateConversionUnitService;
        private readonly ICotizacionService _cotizacionService;
        private readonly IAprobacionesServices _aprobacionesServices;
        private readonly PaginationOptions _paginationOptions;

        public AppDetailQuotesService(IUnitOfWork unitOfWork,
                                       IOptions<PaginationOptions> options,
                                        IMapper mapper,
                                        IAppProductsService appProductsService,
                                        IAppUnitsService appUnitsService,
                                        IAppStatusQuoteService appStatusQuoteService,
                                        ITPaTasaReferencialServices tPaTasaReferencialServices,
                                        IAppDetailQuotesConversionUnitService appDetailQuotesConversionUnitService,
                                        IAppTemplateConversionUnitService appTemplateConversionUnitService,
                                        ICotizacionService cotizacionService,
                                         IAprobacionesServices aprobacionesServices
                                         
            
                                        
                                        
            )
        {
            _unitOfWork = unitOfWork;
           
            _mapper = mapper;
            _appProductsService = appProductsService;
            _appUnitsService = appUnitsService;
            _appStatusQuoteService = appStatusQuoteService;
            _tPaTasaReferencialServices = tPaTasaReferencialServices;
            _appDetailQuotesConversionUnitService = appDetailQuotesConversionUnitService;
            _appTemplateConversionUnitService = appTemplateConversionUnitService;
            _cotizacionService = cotizacionService;
            _aprobacionesServices = aprobacionesServices;
            _paginationOptions = options.Value;
        }

        public async Task<List<AppDetailQuotes>> GetAll()
        {

            var appDetailQuotes = await _unitOfWork.AppDetailQuotesRepository.GetAll();

            return appDetailQuotes;
        }

        public async Task<ApiResponse<List<AppDetailQuotesGetDto>>> GetListAppDetailQuoteByAppGeneralQuotesId(int appGeneralQuotesId)
        {
           

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            List<AppDetailQuotesGetDto> resultDto = new List<AppDetailQuotesGetDto>();
            ApiResponse<List<AppDetailQuotesGetDto>> response = new ApiResponse<List<AppDetailQuotesGetDto>>(resultDto);
            try
            {
                var listAppDetailQuotes = await RecalculaAppDetailQuoteByAppGeneralQuotesId(appGeneralQuotesId);
                
                //var listAppDetailQuotes = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotesId);

                resultDto = _mapper.Map<List<AppDetailQuotesGetDto>>(listAppDetailQuotes);



                foreach (var item in resultDto)
                {

                    AppProducts appProductsFind = await _appProductsService.GetById(item.IdProducto);
                    if (appProductsFind != null)
                    {
                        AppProductsGetDto appProductsGetDto = _mapper.Map<AppProductsGetDto>(appProductsFind);

                        AppUnits AppUnitsProductionFind = await _appUnitsService.GetById((int)appProductsFind.ProductionUnitId);
                        if (AppUnitsProductionFind != null)
                        {
                            AppUnitsGetDto AppUnitsProductionGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsProductionFind);
                            appProductsGetDto.ProductionUnitGetDto = AppUnitsProductionGetDto;
                        }


                        if (appProductsFind.UrlImage == "" || appProductsFind.UrlImage == null)
                        {
                            appProductsGetDto.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                        }
                        else
                        {
                            appProductsGetDto.Link = _paginationOptions.UrlGetFiles + appProductsFind.UrlImage;
                        }
                       

                        item.AppProductsGetDto = appProductsGetDto;
                    }

                    AppUnits AppUnitsFind = await _appUnitsService.GetById(item.IdUnidad);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        item.AppUnitsGetDto = appUnitsGetDto;
                    }

                   


                    AppStatusQuote AppStatusQuoteFind = await _appStatusQuoteService.GetById(item.IdEstatus);
                    if (AppStatusQuoteFind != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteGetDto = _mapper.Map<AppStatusQuoteGetDto>(AppStatusQuoteFind);
                        item.AppStatusQuoteGetDto = appStatusQuoteGetDto;
                    }
                    
                    AppTemplateConversionUnitQueryFilter filter = new AppTemplateConversionUnitQueryFilter();
                    filter.AppDetailQuotesId = item.Id;
                    filter.AppUnitIdSince = item.IdUnidad;
                    filter.AppUnitIdUntil = (int)appProductsFind.ProductionUnitId;
                    var detailTemplate = await _appTemplateConversionUnitService.GetTemplateByUnitsInput(filter);

                    item.AppTemplateConversionUnitGetDto = detailTemplate.Data;


                    var detail = await GetById(item.Id);
                    var statusAorobacion = await StatusAprobacion(detail);

                    item.StatusAprobacionDto = statusAorobacion;


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
        public async Task<List<AppDetailQuotes>> RecalculaAppDetailQuoteByAppGeneralQuotesId(int appGeneralQuotesId)
        {


           

           
            try
            {
                var listAppDetailQuotes = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotesId);

                foreach (var item in listAppDetailQuotes)
                {
                    
                    AppStatusQuote AppStatusQuoteFind = await _appStatusQuoteService.GetById(item.IdEstatus);
                    if (AppStatusQuoteFind != null)
                    {

                        if (AppStatusQuoteFind.FlagModificar=="X")
                        {

                            var tasa = await _tPaTasaReferencialServices.GetTasaByFecha(DateTime.Now);
                            var moneda = item.AppGeneralQuotes.IdMtrTipoMoneda;
                            if (moneda==1)
                            {
                                item.PrecioUsd = item.Precio / (decimal)tasa.Tasa;
                                item.TotalUsd = item.PrecioUsd * item.Cantidad;
                                item.PrecioUsd = Math.Truncate(item.PrecioUsd * 10000) / 10000;
                                item.TotalUsd = Math.Truncate(item.TotalUsd * 10000) / 10000;
                            }
                            else
                            {
                                item.Precio = item.PrecioUsd * (decimal)tasa.Tasa;
                                item.Total = item.Precio * item.Cantidad;
                                item.Precio = Math.Truncate(item.Precio * 10000) / 10000;
                                item.Total = Math.Truncate(item.Total * 10000) / 10000;

                            }

                            if (item.IdProductoNavigation!=null)
                            {
                                if (item.IdProductoNavigation.QuantityPerPackage>0)
                                {
                                    item.QuantityPerPackage = item.IdProductoNavigation.QuantityPerPackage;
                                }
                               
                            }

                            await Update(item);
                        }

                    }

                }


                var result = await _unitOfWork.AppDetailQuotesRepository.GetByAppGeneralQuotesId(appGeneralQuotesId);


                return result;

            }
            catch (Exception ex)
            {

              

                return null;
            }




        }

        public async Task<AppDetailQuotes> GetById(int id)
        {
            return await _unitOfWork.AppDetailQuotesRepository.GetById(id);
        }

        public async Task<AppDetailQuotes> Insert(AppDetailQuotes appDetailQuotes)
        {

            try
            {
                await _unitOfWork.AppDetailQuotesRepository.Add(appDetailQuotes);
                await _unitOfWork.SaveChangesAsync();
                return appDetailQuotes;
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message;
                throw;
            }
          


        }
        public async Task<ApiResponse<AppDetailQuotesGetDto>> InsertAppDetailQuotes(AppDetailQuotesCreateDto appDetailQuotesDto)
        {

           
            AppDetailQuotesGetDto resultDto = new AppDetailQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppDetailQuotesGetDto> response = new ApiResponse<AppDetailQuotesGetDto>(resultDto);

            try
            {


              
                AppGeneralQuotes appGeneralQuotesFind = await _unitOfWork.AppGeneralQuotesRepository.GetById(appDetailQuotesDto.AppGeneralQuotesId);
                if (appGeneralQuotesFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No tiene Encabezado de Cotizacion!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


                


                AppProducts appProducts = await _appProductsService.GetById(appDetailQuotesDto.IdProducto);
                if (appProducts == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto No Existe!!! " ;
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }
              

                AppUnits appUnits  = await _appUnitsService.GetById(appDetailQuotesDto.IdUnidad);
                if (appUnits == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

               


                if (appDetailQuotesDto.Cantidad <=0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad no valida!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

               

                var tasa = await _tPaTasaReferencialServices.GetTasaByFecha(DateTime.Now);
                

                var moneda = appGeneralQuotesFind.IdMtrTipoMoneda;
                if (moneda == 1)
                {
                    appDetailQuotesDto.PrecioUsd = appDetailQuotesDto.Precio / (decimal)tasa.Tasa;
                    appDetailQuotesDto.TotalUsd = appDetailQuotesDto.PrecioUsd * appDetailQuotesDto.Cantidad;
                    appDetailQuotesDto.PrecioUsd = Math.Truncate(appDetailQuotesDto.PrecioUsd * 10000) / 10000;
                    appDetailQuotesDto.TotalUsd = Math.Truncate(appDetailQuotesDto.TotalUsd * 10000) / 10000;

                }
                else
                {
                    appDetailQuotesDto.Precio = appDetailQuotesDto.PrecioUsd * (decimal)tasa.Tasa;
                    appDetailQuotesDto.Total = appDetailQuotesDto.Precio * appDetailQuotesDto.Cantidad;
                    appDetailQuotesDto.Precio = Math.Truncate(appDetailQuotesDto.Precio * 10000) / 10000;
                    appDetailQuotesDto.Total = Math.Truncate(appDetailQuotesDto.Total * 10000) / 10000;

                }
                if (!appProducts.RequiereDatosEntrada)
                {
                    appDetailQuotesDto.ValorConvertido = appProducts.QuantityPerPackage;
                    appDetailQuotesDto.UnitPriceBaseProduction = appProducts.UnitPrice;
                    appDetailQuotesDto.UnitPriceConverted = appProducts.UnitPrice;
                    appDetailQuotesDto.CantidadPorUnidadProduccion = appProducts.QuantityPerPackage;
                    appDetailQuotesDto.QuantityPerPackage = appProducts.QuantityPerPackage;
                }
                if (appDetailQuotesDto.Precio <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }
                if (appDetailQuotesDto.Total <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appDetailQuotesDto.PrecioUsd <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio Usd no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }
                if (appDetailQuotesDto.TotalUsd <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio Usd no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appProducts.RequiereDatosEntrada)
                {
                    if (appDetailQuotesDto.AppConversionUnitGenericCreateDto == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Debe indicar la conversion de unidades ";
                        response.Meta = metadata;
                        response.Data = resultDto;
                        return response;

                    }

                }
               



                AppDetailQuotes appDetailQuotes = _mapper.Map<AppDetailQuotes>(appDetailQuotesDto);

               

                    appDetailQuotes.CreatedAt = DateTime.Now;
                appDetailQuotes.FechaRegistro= DateTime.Now;

                appDetailQuotes.UserCreate = "";

                appDetailQuotes.Producto = appProducts.Code;
                appDetailQuotes.ObsSolicitud = appDetailQuotesDto.ObsSolicitud;
                AppDetailQuotes appDetailQuotesInserted = new AppDetailQuotes();

                var detail= await _unitOfWork.AppDetailQuotesRepository.GetByQuetesProduct(appDetailQuotesDto.Cotizacion, appDetailQuotesDto.IdProducto);
                if (detail!=null)
                {

                    AppDetailQuotesUpdateDto updateDto = new AppDetailQuotesUpdateDto();
                    updateDto.Id = detail.Id;
                   
                    updateDto.IdProducto = appDetailQuotesDto.IdProducto;
                    updateDto.Producto = appProducts.Code;
                    updateDto.NombreComercialProducto = appDetailQuotesDto.NombreComercialProducto;
                    updateDto.IdUnidad = appDetailQuotesDto.IdUnidad;
                    updateDto.IdEstatus = appDetailQuotesDto.IdEstatus;
                    updateDto.Cantidad = appDetailQuotesDto.Cantidad;
                    updateDto.CantidadSolicitada = appDetailQuotesDto.CantidadSolicitada;
                    updateDto.Precio = appDetailQuotesDto.Precio;
                    updateDto.Total = appDetailQuotesDto.Total;
                    updateDto.PrecioUsd = appDetailQuotesDto.PrecioUsd;
                    updateDto.TotalUsd = appDetailQuotesDto.TotalUsd;
                    updateDto.PrecioLista = appDetailQuotesDto.PrecioLista;
                    updateDto.Observaciones = appDetailQuotesDto.Observaciones;
                    updateDto.DiasEntrega = appDetailQuotesDto.DiasEntrega;
                    updateDto.UsuarioConectado = "";
                    updateDto.QuantityPerPackage = appDetailQuotesDto.QuantityPerPackage;
                    updateDto.AppConversionUnitGenericCreateDto = appDetailQuotesDto.AppConversionUnitGenericCreateDto;
                    updateDto.ObsSolicitud = appDetailQuotesDto.ObsSolicitud;
                    if (!appProducts.RequiereDatosEntrada)
                    {
                        updateDto.ValorConvertido = appProducts.QuantityPerPackage;
                        updateDto.UnitPriceBaseProduction = appProducts.UnitPrice;
                        updateDto.UnitPriceConverted = appProducts.UnitPrice;
                        updateDto.CantidadPorUnidadProduccion = appProducts.QuantityPerPackage;
                        updateDto.QuantityPerPackage = appProducts.QuantityPerPackage;
                    }

                    var resultUpdate= await UpdateAppDetailQuotes(updateDto);
                    if (resultUpdate.Meta.IsValid)
                    {
                        appDetailQuotesInserted = await GetById(detail.Id);
                    }
                    else
                    {
                        response = resultUpdate;
                        return response;
                    }


                    

                }
                else
                {

                    AppDetailQuotes appDetailQuotesFind = await _unitOfWork.AppDetailQuotesRepository.GetByQuetesProduct(appDetailQuotesDto.Cotizacion, appDetailQuotesDto.IdProducto);
                    if (appDetailQuotesFind != null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Producto Existe en la cotizacion!!! ";
                        response.Meta = metadata;
                        response.Data = resultDto;
                        return response;
                    }

                   

                    appDetailQuotesInserted = await Insert(appDetailQuotes);
                }

               

                await _cotizacionService.IntegrarCotizacion(appDetailQuotesInserted.AppGeneralQuotesId);

                if (appDetailQuotesInserted != null)
                {
                    if (appProducts.RequiereDatosEntrada)
                    {
                        AppDetailQuotesConversionUnitCreateDto appDetailQuotesConversionUnitCreateDto = new AppDetailQuotesConversionUnitCreateDto();
                        appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId = appDetailQuotesInserted.Id;
                        appDetailQuotesConversionUnitCreateDto.AppUnitIdSince = appDetailQuotesDto.AppConversionUnitGenericCreateDto.AppUnitIdSince;
                        appDetailQuotesConversionUnitCreateDto.AppUnitIdUntil = appDetailQuotesDto.AppConversionUnitGenericCreateDto.AppUnitIdUntil;

                        List<AppTemplateConversionUnitGetDto> templateNew = _mapper.Map<List<AppTemplateConversionUnitGetDto>>(appDetailQuotesDto.AppConversionUnitGenericCreateDto.AppTemplateConversionGenericUnitGetDto);
                        appDetailQuotesConversionUnitCreateDto.AppTemplateConversionUnitGetDto = templateNew;


                        await _appDetailQuotesConversionUnitService.CreateAppDetailQuotesConversionUnit(appDetailQuotesConversionUnitCreateDto);

                    }


                    resultDto = _mapper.Map<AppDetailQuotesGetDto>(appDetailQuotesInserted);


                    AppProducts appProductsFind = await _appProductsService.GetById(appDetailQuotesInserted.IdProducto);
                    if (appProductsFind != null)
                    {
                        AppProductsGetDto appProductsGetDto = _mapper.Map<AppProductsGetDto>(appProductsFind);
                        resultDto.AppProductsGetDto = appProductsGetDto;
                    }

                    AppUnits AppUnitsFind = await _appUnitsService.GetById(appDetailQuotesInserted.IdUnidad);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        resultDto.AppUnitsGetDto = appUnitsGetDto;
                    }


                    AppStatusQuote AppStatusQuoteFind = await _appStatusQuoteService.GetById(appDetailQuotesInserted.IdEstatus);
                    if (AppStatusQuoteFind != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteGetDto = _mapper.Map<AppStatusQuoteGetDto>(AppStatusQuoteFind);
                        resultDto.AppStatusQuoteGetDto = appStatusQuoteGetDto;
                    }


                    if (appProducts.RequiereDatosEntrada)
                    {
                        AppTemplateConversionUnitQueryFilter filter = new AppTemplateConversionUnitQueryFilter();
                        filter.AppDetailQuotesId = appDetailQuotesInserted.Id;
                        filter.AppUnitIdSince = appDetailQuotesInserted.IdUnidad;
                        filter.AppUnitIdUntil = (int)appProductsFind.ProductionUnitId;
                        var detailTemplate = await _appTemplateConversionUnitService.GetTemplateByUnitsInput(filter);

                        resultDto.AppTemplateConversionUnitGetDto = detailTemplate.Data;
                    }



                    metadata.IsValid = true;
                    metadata.Message = $"A la Cotizacion: {resultDto.Cotizacion} se le adiciono producto Satisfactoriamente!!";

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


        public async Task<AppDetailQuotes> Update(AppDetailQuotes appDetailQuotes)
        {
            try
            {
                var appDetailQuotesFind = await GetById(appDetailQuotes.Id);
                if (appDetailQuotesFind == null)
                {
                    throw new Exception("Documento No existe");
                }

               

                _unitOfWork.AppDetailQuotesRepository.Update(appDetailQuotes);
                await _unitOfWork.SaveChangesAsync();

                return await GetById(appDetailQuotes.Id);
            }
            catch (Exception ex)
            {
                var m = ex.InnerException.Message;
                return null;
            }
          


        }

        public async Task<ApiResponse<AppDetailQuotesGetDto>> UpdateAppDetailQuotes(AppDetailQuotesUpdateDto appDetailQuotesUpdateDto)
        {
            AppDetailQuotesGetDto resultDto = new AppDetailQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppDetailQuotesGetDto> response = new ApiResponse<AppDetailQuotesGetDto>(resultDto);

            try
            {
                AppDetailQuotes appDetailQuotes = await GetById(appDetailQuotesUpdateDto.Id);

                if (appDetailQuotes == null)
                {
                    metadata.IsValid = false;       
                    metadata.Message = "No existe Detalle para ese producto!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                if (appDetailQuotes.AppGeneralQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "No tiene Encabezado de Cotizacion!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


                AppProducts appProducts = await _appProductsService.GetById(appDetailQuotesUpdateDto.IdProducto);
                if (appProducts == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


                AppUnits appUnits = await _appUnitsService.GetById(appDetailQuotesUpdateDto.IdUnidad);
                if (appUnits == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }




                if (appDetailQuotesUpdateDto.Cantidad <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cantidad no valida!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Debe indicar la conversion de unidades ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appDetailQuotesUpdateDto.PrecioLista <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Debe indicar precio lista";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                var tasa = await _tPaTasaReferencialServices.GetTasaByFecha(DateTime.Now);


                var moneda = appDetailQuotes.AppGeneralQuotes.IdMtrTipoMoneda;
                if (moneda == 1)
                {
                    appDetailQuotesUpdateDto.Precio = Math.Truncate(appDetailQuotesUpdateDto.Precio * 100) / 100;
                    appDetailQuotesUpdateDto.Total = Math.Truncate(appDetailQuotesUpdateDto.Total * 100) / 100;


                    appDetailQuotesUpdateDto.PrecioUsd = appDetailQuotesUpdateDto.Precio / (decimal)tasa.Tasa;
                    appDetailQuotesUpdateDto.TotalUsd = appDetailQuotesUpdateDto.PrecioUsd * appDetailQuotesUpdateDto.Cantidad;
                    
                    appDetailQuotesUpdateDto.PrecioUsd = Math.Truncate(appDetailQuotesUpdateDto.PrecioUsd * 100) / 100;
                    appDetailQuotesUpdateDto.TotalUsd = Math.Truncate(appDetailQuotesUpdateDto.TotalUsd * 100) / 100;

                 




                }
                else
                {

                    appDetailQuotesUpdateDto.PrecioUsd = Math.Truncate(appDetailQuotesUpdateDto.PrecioUsd * 100) / 100;
                    appDetailQuotesUpdateDto.TotalUsd = Math.Truncate(appDetailQuotesUpdateDto.TotalUsd * 100) / 100;

                    appDetailQuotesUpdateDto.Precio = appDetailQuotesUpdateDto.PrecioUsd * (decimal)tasa.Tasa;
                    appDetailQuotesUpdateDto.Total = appDetailQuotesUpdateDto.Precio * appDetailQuotesUpdateDto.Cantidad;
                   
                    appDetailQuotesUpdateDto.Precio = Math.Truncate(appDetailQuotesUpdateDto.Precio * 100) / 100;
                    appDetailQuotesUpdateDto.Total = Math.Truncate(appDetailQuotesUpdateDto.Total * 100) / 100;

                   

                }


                if (appDetailQuotesUpdateDto.Precio <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }
                if (appDetailQuotesUpdateDto.Total <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                if (appDetailQuotesUpdateDto.PrecioUsd <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio Usd no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }
                if (appDetailQuotesUpdateDto.TotalUsd <= 0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Precio Usd no valido!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }




                appDetailQuotes.IdProducto = appDetailQuotesUpdateDto.IdProducto;
                appDetailQuotes.Producto = appProducts.Code;
                appDetailQuotes.IdUnidad = appDetailQuotesUpdateDto.IdUnidad;
                appDetailQuotes.NombreComercialProducto = appDetailQuotesUpdateDto.NombreComercialProducto;
                appDetailQuotes.Observaciones = appDetailQuotesUpdateDto.Observaciones;
                
                appDetailQuotes.Precio = appDetailQuotesUpdateDto.Precio;
                appDetailQuotes.PrecioUsd = appDetailQuotesUpdateDto.PrecioUsd;
                
                appDetailQuotes.Total = appDetailQuotesUpdateDto.Total;
                appDetailQuotes.TotalUsd = appDetailQuotesUpdateDto.TotalUsd;
                appDetailQuotes.Cantidad = appDetailQuotesUpdateDto.Cantidad;
                appDetailQuotes.CantidadSolicitada = appDetailQuotesUpdateDto.CantidadSolicitada;

                appDetailQuotes.FechaRegistro = DateTime.Now;
                appDetailQuotes.UserUpdate = appDetailQuotesUpdateDto.UsuarioConectado;

                appDetailQuotes.DiasEntrega = appDetailQuotesUpdateDto.DiasEntrega;


                appDetailQuotes.ObsSolicitud = appDetailQuotesUpdateDto.ObsSolicitud;

                if (!appProducts.RequiereDatosEntrada)
                {
                    appDetailQuotes.ValorConvertido = appProducts.QuantityPerPackage;
                    appDetailQuotes.UnitPriceBaseProduction = appProducts.UnitPrice;
                    appDetailQuotes.UnitPriceConverted = appProducts.UnitPrice;
                    appDetailQuotes.CantidadPorUnidadProduccion = appProducts.QuantityPerPackage;
                    appDetailQuotes.QuantityPerPackage = appProducts.QuantityPerPackage;
                }


                AppDetailQuotes appDetailQuotesUpdated = await Update(appDetailQuotes);

                await _cotizacionService.IntegrarCotizacion(appDetailQuotesUpdated.AppGeneralQuotesId);


                if (appDetailQuotesUpdated != null)
                {

                    if (appDetailQuotesUpdateDto.SolicitarPrecio)
                    {

                        var renglon =await _unitOfWork.RenglonRepository.GetByCotizacionProducto(appDetailQuotesUpdated.Cotizacion, appDetailQuotesUpdated.IdProductoNavigation.ExternalCode);


                        var wsmy639Response = await _aprobacionesServices.CreateAprobacion(renglon.Cotizacion, renglon.Renglon, 1, appDetailQuotesUpdateDto.UsuarioConectado);
                        if (wsmy639Response.Meta.IsValid)
                        {
                            var activarWorkflowResponse = await _aprobacionesServices.ActivarWORKFLOW(renglon.Cotizacion, renglon.Renglon, 1, appDetailQuotesUpdateDto.UsuarioConectado, appDetailQuotesUpdated);
                        }


                    }


                   


                    if (appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto.AppTemplateConversionGenericUnitGetDto!=null)
                    {
                        AppDetailQuotesConversionUnitCreateDto appDetailQuotesConversionUnitCreateDto = new AppDetailQuotesConversionUnitCreateDto();
                        appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId = appDetailQuotesUpdated.Id;
                        appDetailQuotesConversionUnitCreateDto.AppUnitIdSince = appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto.AppUnitIdSince;
                        appDetailQuotesConversionUnitCreateDto.AppUnitIdUntil = appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto.AppUnitIdUntil;

                        List<AppTemplateConversionUnitGetDto> templateNew = _mapper.Map<List<AppTemplateConversionUnitGetDto>>(appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto.AppTemplateConversionGenericUnitGetDto);
                        appDetailQuotesConversionUnitCreateDto.AppTemplateConversionUnitGetDto = templateNew;

                        if (appDetailQuotesUpdateDto.AppConversionUnitGenericCreateDto.AppTemplateConversionGenericUnitGetDto.Count > 0)
                        {
                            await _appDetailQuotesConversionUnitService.CreateAppDetailQuotesConversionUnit(appDetailQuotesConversionUnitCreateDto);
                        }
                    }
                   
                  



                    resultDto = _mapper.Map<AppDetailQuotesGetDto>(appDetailQuotesUpdated);


                    AppProducts appProductsFind = await _appProductsService.GetById(appDetailQuotesUpdated.IdProducto);
                    if (appProductsFind != null)
                    {
                        AppProductsGetDto appProductsGetDto = _mapper.Map<AppProductsGetDto>(appProductsFind);
                        resultDto.AppProductsGetDto = appProductsGetDto;
                    }

                    AppUnits AppUnitsFind = await _appUnitsService.GetById(appDetailQuotesUpdated.IdUnidad);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        resultDto.AppUnitsGetDto = appUnitsGetDto;
                    }

                    AppStatusQuote AppStatusQuoteFind = await _appStatusQuoteService.GetById(appDetailQuotesUpdated.IdEstatus);
                    if (AppStatusQuoteFind != null)
                    {
                        AppStatusQuoteGetDto appStatusQuoteGetDto = _mapper.Map<AppStatusQuoteGetDto>(AppStatusQuoteFind);
                        resultDto.AppStatusQuoteGetDto = appStatusQuoteGetDto;
                    }


                    AppTemplateConversionUnitQueryFilter filter = new AppTemplateConversionUnitQueryFilter();
                    filter.AppDetailQuotesId = appDetailQuotesUpdated.Id;
                    filter.AppUnitIdSince = appDetailQuotesUpdated.IdUnidad;
                    filter.AppUnitIdUntil = (int)appProductsFind.ProductionUnitId;
                    var detailTemplate = await _appTemplateConversionUnitService.GetTemplateByUnitsInput(filter);

                    resultDto.AppTemplateConversionUnitGetDto = detailTemplate.Data;

                    metadata.IsValid = true;
                    metadata.Message = $"Cotizacion: {resultDto.Cotizacion} actualizado Satisfactoriamente!!";

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


        public async Task<ApiResponse<bool>> DeleteDetailQuotes(AppDetailQuotesDeleteDto appDetailQuotesDeleteDto)
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

                AppDetailQuotes appDetailQuotes = await GetById(appDetailQuotesDeleteDto.Id);
                if (appDetailQuotes == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion No Existe!!! " + appDetailQuotesDeleteDto.Cotizacion;
                    response.Meta = metadata;
                    response.Data = false;
                    return response;
                }

                AppStatusQuote AppStatusQuoteFind = await _appStatusQuoteService.GetById(appDetailQuotes.IdEstatus);
                if (AppStatusQuoteFind != null)
                {

                    if (AppStatusQuoteFind.FlagModificar == "X")
                    {

                        await _cotizacionService.DeleteCotizacionRenglon(appDetailQuotes);

                        await DeteleAppDetailQuotesByDetailQuotesId(appDetailQuotesDeleteDto.Id);
                       
                        await Delete(appDetailQuotesDeleteDto.Id);

                        metadata.IsValid = true;
                        metadata.Message = $"Cotizacion: {appDetailQuotesDeleteDto.Cotizacion} Eliminada Satisfactoriamente!!";

                        response.Meta = metadata;
                        response.Data = resultDto;

                    }
                    else
                    {
                        metadata.IsValid = false;
                        metadata.Message = $"Cotizacion: {appDetailQuotesDeleteDto.Cotizacion} No puede ser eliminada.Esta en Estatus: {AppStatusQuoteFind.Descripcion}";

                        response.Meta = metadata;
                        response.Data = resultDto;

                    }

                }



               

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


        public async Task<bool> Delete(int id)
        {

            try
            {
                await _unitOfWork.AppDetailQuotesRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            catch (Exception ex )
            {
                var message = ex.InnerException.Message;
                return false;
            }
           
        }
        public async Task DeteleAppDetailQuotesByDetailQuotesId(int appDetailQuotesId)
        {

            try
            {
                var appDetailQuotesConversionUnit = await _unitOfWork.AppDetailQuotesConversionUnitRepository.GetByAppDetailQuotesId(appDetailQuotesId);

                if (appDetailQuotesConversionUnit != null)
                {
                    foreach (var item in appDetailQuotesConversionUnit)
                    {
                        await _unitOfWork.AppDetailQuotesConversionUnitRepository.Delete(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message;
                throw;
            }

           

        }

        public async Task<ApiResponse<bool>> GanarPerder(AppGanarPerderDto appGanarPerderDto)
        {

            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);


            var statusGanada = await _appStatusQuoteService.GetStatusGanada();
            var statusPerdida = await _appStatusQuoteService.GetStatusPerdida();
            int status = 0;
            if (appGanarPerderDto.CondicionId == 1)
            {
                status = statusGanada.Id;
            }
            else if (appGanarPerderDto.CondicionId == 2)
            {
                status = statusPerdida.Id;
            }

            var appDetailQuotes = await GetById(appGanarPerderDto.AppDetailQuotesId);
            if (appDetailQuotes==null)
            {
                metadata.IsValid = false;
                metadata.Message = "Id Cotizacion No Existe!!! " ;
                response.Meta = metadata;
                response.Data = false;
                return response;
            }
            else
            {

                appDetailQuotes.IdEstatus = status;
                appDetailQuotes.RazonGanadaPerdida = appGanarPerderDto.MotivoId;
                appDetailQuotes.Competidor = appGanarPerderDto.CompetidorId;
                await Update(appDetailQuotes);

                var generalQuotes = await _unitOfWork.AppGeneralQuotesRepository.GetById(appDetailQuotes.AppGeneralQuotesId);
                if (generalQuotes != null)
                {
                    generalQuotes.IdEstatus = status;
                    _unitOfWork.AppGeneralQuotesRepository.Update(generalQuotes);
                    await _unitOfWork.SaveChangesAsync();

                }



                
                if ( appDetailQuotes.PrecioUsd >= appDetailQuotes.IdProductoNavigation.UnitPrice)
                {
                    var renglon = await _unitOfWork.RenglonRepository.GetByCotizacionProducto(appDetailQuotes.Cotizacion, appDetailQuotes.IdProductoNavigation.ExternalCode);
                    var wsmy639Response = await _aprobacionesServices.CreateAprobacionAprobada(renglon.Cotizacion, renglon.Renglon, 1, appDetailQuotes.UserUpdate);
                    if (wsmy639Response.Meta.IsValid)
                    {
                        var activarWorkflowResponse = await _aprobacionesServices.ActivarWORKFLOW(renglon.Cotizacion, renglon.Renglon, 1, appDetailQuotes.UserUpdate, appDetailQuotes);
                    }
                }

                await _cotizacionService.IntegrarCotizacion(appDetailQuotes.AppGeneralQuotesId);



                metadata.IsValid = true;
                metadata.Message = "Cotizacion Actualizada!!! ";
                response.Meta = metadata;
                response.Data = false;
                return response;
            }


            

        }

        public async Task<StatusAprobacionDto> StatusAprobacion(AppDetailQuotes appDetailQuotes)
        {


            StatusAprobacionDto result = new StatusAprobacionDto();

            var general = await _unitOfWork.AppGeneralQuotesRepository.GetById(appDetailQuotes.AppGeneralQuotesId);


            var renglon = await _unitOfWork.RenglonRepository.GetByCotizacionProducto(appDetailQuotes.Cotizacion, appDetailQuotes.IdProductoNavigation.ExternalCode);

            if (renglon!=null)
            {
                var wsmy639Response = await _aprobacionesServices.GetByCotizacionRenglonPrpopuesta(renglon.Cotizacion, renglon.Renglon, 1);
                if (wsmy639Response != null)
                {

                    if ((bool)wsmy639Response.FlagAprobado && !(bool)wsmy639Response.FlagCerrado)
                    {
                        wsmy639Response.FlagAprobado = false;
                        _unitOfWork.AprobacionesRepository.Update(wsmy639Response);
                        await _unitOfWork.SaveChangesAsync();
                    }

                    result.FlagAprobado = wsmy639Response.FlagAprobado;
                    result.FlagCerrado = wsmy639Response.FlagCerrado;
                    result.ValorVentaAprobar = wsmy639Response.ValorVentaAprobar;
                    result.ValorVentaAprobarUsd = wsmy639Response.ValorVentaAprobarUsd;

                    if ((bool)result.FlagAprobado && (bool)result.FlagCerrado)
                    {
                        result.Aprobado = true;

                        result.Color = "prymary";
                        result.StatusString = "APROBADO";
                    }
                    if (!(bool)result.FlagAprobado && (bool)result.FlagCerrado)
                    {
                        result.Aprobado = false;

                        result.Color = "danger";
                        result.StatusString = "Rechazado";
                    }
                    if (!(bool)result.FlagAprobado && !(bool)result.FlagCerrado)
                    {
                        result.Aprobado = false;

                        result.Color = "danger";
                        result.StatusString = "PENDIENTE";
                    }
                    if (appDetailQuotes.PrecioUsd >= appDetailQuotes.UnitPriceBaseProduction)
                    {
                        result.Aprobado = true;
                        result.Color = "prymary";
                        result.StatusString = "APROBADO";
                    }

                    if (appDetailQuotes.PrecioUsd < wsmy639Response.ValorVentaAprobarUsd)
                    {
                        result.Aprobado = false;
                        result.Color = "danger";
                        result.StatusString = "ENVIAR APROBACION";
                    }

                    if (general.IdMtrTipoMoneda==1 && appDetailQuotes.PrecioUsd < wsmy639Response.ValorVentaAprobarUsd)
                    {
                        result.Aprobado = false;
                        result.Color = "danger";
                        result.StatusString = "ENVIAR APROBACION";
                    }
                }
                else
                {
                    if (appDetailQuotes.PrecioUsd < appDetailQuotes.UnitPriceBaseProduction)
                    {
                        result.Aprobado = false;
                        result.Color = "danger";
                        result.StatusString = "ENVIAR APROBACION";
                    }
                    else
                    {
                        result.Aprobado = true;
                        result.Color = "prymary";
                        result.StatusString = "APROBADO";

                    }
                    if (general.IdMtrTipoMoneda == 1 )
                    {
                        result.Aprobado = false;
                        result.Color = "danger";
                        result.StatusString = "ENVIAR APROBACION";
                    }

                }
            }
            else
            {
                if (appDetailQuotes.PrecioUsd < appDetailQuotes.UnitPriceBaseProduction)
                {
                    result.Aprobado = false;
                    result.Color = "danger";
                    result.StatusString = "ENVIAR APROBACION";
                }
                else
                {
                    result.Aprobado = true;
                    result.Color = "prymary";
                    result.StatusString = "APROBADO";

                }
                if (general.IdMtrTipoMoneda == 1)
                {
                    result.Aprobado = false;
                    result.Color = "danger";
                    result.StatusString = "ENVIAR APROBACION";
                }
            }
        
          

            return result;

        }



        public async Task<bool> RequiereAprobacionAppGeneralQuotesId(int appGeneralQuotesId)
        {


           

            bool resultDto = false;
           
            try
            {
                var listAppDetailQuotes = await RecalculaAppDetailQuoteByAppGeneralQuotesId(appGeneralQuotesId);

             



                foreach (var item in listAppDetailQuotes)
                {

    
                    var detail = await GetById(item.Id);
                    var statusAporobacion = await StatusAprobacion(detail);

                    if (!statusAporobacion.Aprobado)
                    {
                        resultDto = true;
                        return resultDto;
                    }
                   
                    


                }



               
                return resultDto;

            }
            catch (Exception ex)
            {

              

                return resultDto;
            }




        }


    }
}
