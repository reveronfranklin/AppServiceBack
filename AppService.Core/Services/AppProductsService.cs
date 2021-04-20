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
    public class AppProductsService: IAppProductsService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppUnitsService _appUnitsService;
        private readonly IAppProductVariableSearchTextService _appProductVariableSearchTextService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;
        private readonly IAppSubCategoryService _appSubCategoryService;
        private readonly PaginationOptions _paginationOptions;
        
        public AppProductsService(IUnitOfWork unitOfWork, 
                                IOptions<PaginationOptions> options, 
                                IMapper mapper,
                                IAppUnitsService appUnitsService,
                                IAppProductVariableSearchTextService appProductVariableSearchTextService,
                                IMtrTipoMonedaService mtrTipoMonedaService,
                                IAppSubCategoryService appSubCategoryService)
        {
            _unitOfWork = unitOfWork;
          
            _appUnitsService = appUnitsService;
            _appProductVariableSearchTextService = appProductVariableSearchTextService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _appSubCategoryService = appSubCategoryService;
            _paginationOptions = options.Value;
            _mapper = mapper;
        }

        public async Task<List<AppProducts>> GetAll()
        {

            var appProducts = await _unitOfWork.AppProductsRepository.GetAll();

            return appProducts;
        }

        public async Task<ApiResponse<List<AppProductsGetDto>>> GetAll(AppProdutsQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            List<AppProductsGetDto> resultDto = new List<AppProductsGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            ApiResponse<List<AppProductsGetDto>> response = new ApiResponse<List<AppProductsGetDto>>(resultDto);

            try
            {
                var appProducts = await _unitOfWork.AppProductsRepository.GetAllFilter(filters);
                if (appProducts != null)
                {
                    List<AppProductsGetDto> appProductsDto = _mapper.Map<List<AppProductsGetDto>>(appProducts);
                    foreach (var item in appProductsDto)
                    {

                        if (item.UrlImage=="" || item.UrlImage==null)
                        {
                            item.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                        }
                        else
                        {
                            item.Link = _paginationOptions.UrlGetFiles + item.UrlImage;
                        }
                       
                        AppUnits AppUnitsFind = await _appUnitsService.GetById((int)item.AppUnitsId);
                        if (AppUnitsFind != null)
                        {
                            AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                            item.AppUnitsGetDto = appUnitsGetDto;
                        }

                        AppUnitsFind = await _appUnitsService.GetById((int)item.ProductionUnitId);
                        if (AppUnitsFind != null)
                        {
                            AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                            item.ProductionUnitGetDto = appUnitsGetDto;
                        }


                        MtrTipoMoneda MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)item.PrymaryMtrMonedaId);
                        if (MtrTipoMonedaFind != null)
                        {
                            MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                            item.PrymaryMtrMonedaGetDto = mtrTipoMonedaDto;
                        }

                        MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)item.SecundaryMtrMonedaId);
                        if (MtrTipoMonedaFind != null)
                        {
                            MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                            item.SecundaryMtrMonedaGetDto = mtrTipoMonedaDto;
                        }

                        AppSubCategory AppSubCategoryFind = await _appSubCategoryService.GetById((int)item.AppSubCategoryId);
                        if (AppSubCategoryFind != null)
                        {
                            AppSubCategoryGetDto appSubCategoryGetDto = _mapper.Map<AppSubCategoryGetDto>(AppSubCategoryFind);
                            item.AppSubCategoryGetDto = appSubCategoryGetDto;
                        }

                    }




                    response.Data = appProductsDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    metadata.IsValid = true;
                    metadata.Message = "No Data....";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
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

        public async Task<ApiResponse<List<AppProductsGetDto>>> GetAllByVariable(List<AppVariableSearchCompareQueryFilter> filter)
        {

         

            List<AppProductsGetDto> resultDto = new List<AppProductsGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            ApiResponse<List<AppProductsGetDto>> response = new ApiResponse<List<AppProductsGetDto>>(resultDto);

            try
            {
                //var productByVariable = await _appProductVariableSearchTextService.GetAllByListVariable(filter);

                if (filter.Count<=0)
                {
                    metadata.IsValid = true;
                    metadata.Message = "No Data....";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                var appProducts = await _unitOfWork.AppProductsRepository.GetAllByVarible(filter);
                if (appProducts != null)
                {
                    List<AppProductsGetDto> appProductsDto = _mapper.Map<List<AppProductsGetDto>>(appProducts);
                    foreach (var item in appProductsDto)
                    {
                        AppUnits AppUnitsFind = await _appUnitsService.GetById((int)item.AppUnitsId);
                        if (AppUnitsFind != null)
                        {
                            AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                            item.AppUnitsGetDto = appUnitsGetDto;
                        }


                        AppUnits ProductionUnitFind = await _appUnitsService.GetById((int)item.ProductionUnitId);
                        if (ProductionUnitFind != null)
                        {
                            AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(ProductionUnitFind);
                            item.ProductionUnitGetDto = appUnitsGetDto;
                        }

                        


                        if (item.UrlImage == "" || item.UrlImage == null)
                        {
                            item.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                        }
                        else
                        {
                            item.Link = _paginationOptions.UrlGetFiles + item.UrlImage;
                        }
                    }




                    response.Data = appProductsDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    metadata.IsValid = true;
                    metadata.Message = "No Data....";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
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

        public async Task<AppProducts> GetById(int id)
        {
            return await _unitOfWork.AppProductsRepository.GetById(id);
        }

        public async Task<AppProducts> GetByCode(string code)
        {
            return await _unitOfWork.AppProductsRepository.GetByCode(code);
        }

        public async Task<AppProducts> Insert(AppProducts appProducts)
        {


            await _unitOfWork.AppProductsRepository.Add(appProducts);
            await _unitOfWork.SaveChangesAsync();
            return appProducts;


        }

        public async Task<ApiResponse<AppProductsGetDto>> InsertProducts(AppProductsCreateDto appProductsCreateDto )
        {
            AppProductsGetDto resultDto = new AppProductsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppProductsGetDto> response = new ApiResponse<AppProductsGetDto>(resultDto);

            try
            {

                if (appProductsCreateDto.UrlImage==null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Url Imagen no valida";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                if (appProductsCreateDto.ExternalCode == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo Externo no es valido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


                AppProducts appProductsFind = await GetByCode(appProductsCreateDto.Code);
                if (appProductsFind!=null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto ya existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                AppUnits appUnitsFind  = await _appUnitsService.GetById((int)appProductsCreateDto.AppUnitsId);
                if (appUnitsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad venta del Producto No existe";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                appUnitsFind = await _appUnitsService.GetById((int)appProductsCreateDto.ProductionUnitId);
                if (appUnitsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad Produccion del Producto No existe";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }


               



                MtrTipoMoneda mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById((long)appProductsCreateDto.PrymaryMtrMonedaId);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Primaria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById((long)appProductsCreateDto.SecundaryMtrMonedaId);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Secundaria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                AppSubCategory appSubCategory  = await _unitOfWork.AppSubCategoryRepository.GetById((int)appProductsCreateDto.AppSubCategoryId);
                if (appSubCategory == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Subcategoria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


               
                AppProducts appProductsCreate  = _mapper.Map<AppProducts>(appProductsCreateDto);


                appProductsCreate.CreatedAt = DateTime.Now;
                appProductsCreate.UserCreate = appProductsCreateDto.UsuarioConectado;
                appProductsCreate.UserUpdate = appProductsCreateDto.UsuarioConectado;
                appProductsCreate.UpdatedAt= DateTime.Now;
                if (appProductsCreate.VariablesSearchText==null)
                {
                    appProductsCreate.VariablesSearchText = "";
                }
                

                AppProducts appProductsInserted = await Insert(appProductsCreate);



                if (appProductsInserted != null)
                {
                    resultDto = _mapper.Map<AppProductsGetDto>(appProductsInserted);

                    AppUnits AppUnitsFind = await _appUnitsService.GetById((int)appProductsInserted.AppUnitsId);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        resultDto.AppUnitsGetDto = appUnitsGetDto;
                    }

                    
                    if (resultDto.UrlImage == "" || resultDto.UrlImage == null)
                    {
                        resultDto.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                    }
                    else
                    {
                        resultDto.Link = _paginationOptions.UrlGetFiles + resultDto.UrlImage;
                    }

                    metadata.IsValid = true;
                    metadata.Message = $"Producto: {resultDto.Code} creado Satisfactoriamente!!";

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

        public async Task<AppProducts> Update(AppProducts appProducts)
        {

            try
            {
                var appProductsFind = await GetById(appProducts.Id);
                if (appProductsFind == null)
                {
                    throw new Exception("Producto No existe");
                }

                _unitOfWork.AppProductsRepository.Update(appProducts);
                await _unitOfWork.SaveChangesAsync();

                var productUpdated =await GetById(appProducts.Id);

                return productUpdated;
            }
            catch (Exception ex)
            {

                var msg = ex.InnerException.Message;
                return null;
               
            }

           


        }

        public async Task<ApiResponse<AppProductsGetDto>> UpdateProducts(AppProductsUpdateDto appProductsUpdateDto)
        {
            AppProductsGetDto resultDto = new AppProductsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppProductsGetDto> response = new ApiResponse<AppProductsGetDto>(resultDto);

            try
            {

                AppProducts appProductsFind = await GetById(appProductsUpdateDto.Id);
                if (appProductsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                if (appProductsUpdateDto.ExternalCode == "")
                {
                    metadata.IsValid = false;
                    metadata.Message = "Codigo Externo no es valido";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                AppUnits appUnitsFind = await _appUnitsService.GetById((int)appProductsUpdateDto.AppUnitsId);
                if (appUnitsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad venta del Producto No existe";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }

                appUnitsFind = await _appUnitsService.GetById((int)appProductsUpdateDto.ProductionUnitId);
                if (appUnitsFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Unidad Produccion del Producto No existe";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;
                }






                MtrTipoMoneda mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById((long)appProductsUpdateDto.PrymaryMtrMonedaId);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Primaria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                mtrTipoMonedaFind = await _unitOfWork.MtrTipoMonedaRepository.GetById((long)appProductsUpdateDto.SecundaryMtrMonedaId);
                if (mtrTipoMonedaFind == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Moneda Secundaria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                AppSubCategory appSubCategory = await _unitOfWork.AppSubCategoryRepository.GetById((int)appProductsUpdateDto.AppSubCategoryId);
                if (appSubCategory == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Subcategoria No Existe!!! ";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }


                appProductsFind.ProductionUnitId = appProductsUpdateDto.ProductionUnitId;
                appProductsFind.AppUnitsId = appProductsUpdateDto.AppUnitsId;
                appProductsFind.AppSubCategoryId = appProductsUpdateDto.AppSubCategoryId;
                appProductsFind.PrymaryMtrMonedaId = appProductsUpdateDto.PrymaryMtrMonedaId;
                appProductsFind.SecundaryMtrMonedaId = appProductsUpdateDto.SecundaryMtrMonedaId;
                appProductsFind.UnitPrice = appProductsUpdateDto.UnitPrice;
                appProductsFind.Description1 = appProductsUpdateDto.Description1;
                appProductsFind.Description2 = appProductsUpdateDto.Description2;
                appProductsFind.ExternalCode = appProductsUpdateDto.ExternalCode;


                appProductsFind.UserUpdate = appProductsUpdateDto.UsuarioConectado;
                appProductsFind.UpdatedAt = DateTime.Now;


                AppProducts appProductsUpdated = await Update(appProductsFind);



                if (appProductsUpdated != null)
                {
                    resultDto = _mapper.Map<AppProductsGetDto>(appProductsUpdated);

                    AppUnits AppUnitsFind = await _appUnitsService.GetById((int)appProductsUpdated.AppUnitsId);
                    if (AppUnitsFind != null)
                    {
                        AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                        resultDto.AppUnitsGetDto = appUnitsGetDto;
                    }
                    
                    if (resultDto.UrlImage == "" || resultDto.UrlImage == null)
                    {
                        resultDto.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                    }
                    else
                    {
                        resultDto.Link = _paginationOptions.UrlGetFiles + resultDto.UrlImage;
                    }


                    metadata.IsValid = true;
                    metadata.Message = $"Producto: {resultDto.Code} Actualizado Satisfactoriamente!!";

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

        public async Task<bool> Delete(short id)
        {
            await _unitOfWork.AppProductsRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

       

        public async Task<ApiResponse<bool>> DeleteProduct(AppProductsDeleteDto dto)
        {
            bool resultDto = false;

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);

            try
            {

                AppProducts product = await GetById(dto.Id);

                if (product == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Producto No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                var recipes = await _unitOfWork.AppRecipesRepository.GetRecipesByProductId(dto.Id);

                if (recipes != null || recipes.Count>0)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Producto existe en la formulacion!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }







                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"Producto Eliminado Satisfactoriamente!";

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


        public async Task<ApiResponse<AppProductsGetDto>> GetProduct(int id)
        {
            AppProductsGetDto resultDto = new AppProductsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppProductsGetDto> response = new ApiResponse<AppProductsGetDto>(resultDto);

            try
            {

                AppProducts appProductsFind = await GetById(id);
                if (appProductsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Codigo de producto no existe, verifique por favor";
                    response.Meta = metadata;
                    response.Data = resultDto;
                    return response;

                }

                resultDto = _mapper.Map<AppProductsGetDto>(appProductsFind);

                AppUnits AppUnitsFind = await _appUnitsService.GetById((int)appProductsFind.AppUnitsId);
                if (AppUnitsFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                    resultDto.AppUnitsGetDto = appUnitsGetDto;
                }

                AppUnitsFind = await _appUnitsService.GetById((int)appProductsFind.ProductionUnitId);
                if (AppUnitsFind != null)
                {
                    AppUnitsGetDto appUnitsGetDto = _mapper.Map<AppUnitsGetDto>(AppUnitsFind);
                    resultDto.ProductionUnitGetDto = appUnitsGetDto;
                }


                MtrTipoMoneda MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)appProductsFind.PrymaryMtrMonedaId);
                if (MtrTipoMonedaFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                    resultDto.PrymaryMtrMonedaGetDto = mtrTipoMonedaDto;
                }

                MtrTipoMonedaFind = await _mtrTipoMonedaService.GetById((long)appProductsFind.SecundaryMtrMonedaId);
                if (MtrTipoMonedaFind != null)
                {
                    MtrTipoMonedaDto mtrTipoMonedaDto = _mapper.Map<MtrTipoMonedaDto>(MtrTipoMonedaFind);
                    resultDto.SecundaryMtrMonedaGetDto = mtrTipoMonedaDto;
                }

                AppSubCategory AppSubCategoryFind = await _appSubCategoryService.GetById((int)appProductsFind.AppSubCategoryId);
                if (AppSubCategoryFind != null)
                {
                    AppSubCategoryGetDto appSubCategoryGetDto = _mapper.Map<AppSubCategoryGetDto>(AppSubCategoryFind);
                    resultDto.AppSubCategoryGetDto = appSubCategoryGetDto;
                }

                if (resultDto.UrlImage == "" || resultDto.UrlImage == null)
                {
                    resultDto.Link = _paginationOptions.UrlGetFiles + "NoImage.png";
                }
                else
                {
                    resultDto.Link = _paginationOptions.UrlGetFiles + resultDto.UrlImage;
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


        //public async Task UpdateProductByVariablesSearchText(int id)
        //{


        //    var producto = await GetById(id);

        //    var receta = await _unitOfWork.AppRecipesRepository.Include(x => x.AppIngredients).Include(x => x.AppVariable).Where(x => x.AppproductsId == id && x.IncludeInSearch == true).ToListAsync();
        //    string searchText = "";
        //    if (receta != null)
        //    {


        //        foreach (var item in receta)
        //        {


        //            var variableSeachtText = await _context.AppVariableSearch
        //                    .Where(x => x.AppVariableId == item.AppVariableId & x.AppSubCategoryId == producto.AppSubCategoryId)
        //                    .FirstOrDefaultAsync();
        //            if (variableSeachtText == null)
        //            {

        //            }

        //            searchText = item.AppVariableId.ToString() + item.




        //        }

        //    }




        //}


    }
}
