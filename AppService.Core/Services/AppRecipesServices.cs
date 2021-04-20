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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppRecipesServices: IAppRecipesServices
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppProductsService _appProductsService;
        private readonly IHelperService _helperService;
        private readonly IAppVariablesService _appVariablesService;
  
        private readonly IAppVariableSearchService _appVariableSearchService;
        private readonly PaginationOptions _paginationOptions;

        public AppRecipesServices(IUnitOfWork unitOfWork, IMapper mapper, IOptions<PaginationOptions> options,
                                    IAppProductsService appProductsService,
                                    IHelperService helperService,
                                    IAppVariablesService appVariablesService,
                                    
                                    IAppVariableSearchService appVariableSearchService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _appProductsService = appProductsService;
            _helperService = helperService;
            _appVariablesService = appVariablesService;

            _appVariableSearchService = appVariableSearchService;
            _paginationOptions = options.Value;
        }

        public async Task<List<AppRecipes>> GetRecipesByProductId(int productId)
        {

            return await _unitOfWork.AppRecipesRepository.GetRecipesByProductId(productId);

        }

        public async Task<List<AppRecipes>> GetAllRecipesByProductId(int productId)
        {

            return await _unitOfWork.AppRecipesRepository.GetAllRecipesByProductId(productId);

        }

        public async Task<List<AppRecipesGetDto>> GetRecipesGetDtoByProductId(AppRecipesQueryFilter filter)
        {
            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();
            
            var recipes = await GetAllRecipesByProductId(filter.AppproductsId);
            if (recipes != null)
            {
                if (filter.SearchText!="" && filter.SearchText!=null)
                {

                    recipes= recipes.Where(x => x.Description.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Code.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower()) || x.Formula.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).ToList();

                    
                }


                List<AppRecipesGetDto> recipesDto = _mapper.Map<List<AppRecipesGetDto>>(recipes);

                foreach (var item in recipesDto)
                {
                    AppProducts appProductsFind = await _appProductsService.GetById((int)item.AppproductsId);
                    if (appProductsFind != null)
                    {
                        AppProductsGetDto appProductsGetDto = _mapper.Map<AppProductsGetDto>(appProductsFind);
                        item.AppProductsGetDto = appProductsGetDto;

                    }
                    AppVariables appVariablesFind = await _appVariablesService.GetById((int)item.AppVariableId);
                    if (appVariablesFind != null)
                    {
                        AppVariablesGetDto appVariablesGetDto = _mapper.Map<AppVariablesGetDto>(appVariablesFind);
                        item.AppVariablesGetDto = appVariablesGetDto;

                    }
                    if (item.AppIngredientsId!=null)
                    {
                        AppIngredients appIngredientsFind = await _unitOfWork.AppIngredientsRepository.GetById((int)item.AppIngredientsId);
                        if (appIngredientsFind != null)
                        {
                            AppIngredientsGetDto appIngredientsGetDto = _mapper.Map<AppIngredientsGetDto>(appIngredientsFind);
                            item.AppIngredientsGetDto = appIngredientsGetDto;

                        }
                    }

                   

                  

                }


               


                resultDto = recipesDto;
            }

            return resultDto;

        }

        public async Task<AppRecipes> GetById(int id)
        {
            return await _unitOfWork.AppRecipesRepository.GetById(id);
        }

        public async Task<AppRecipes> Insert(AppRecipes appRecipes)
        {


            await _unitOfWork.AppRecipesRepository.Add(appRecipes);
            await _unitOfWork.SaveChangesAsync();
            return appRecipes;


        }

        public async Task<ApiResponse<List<AppRecipesGetDto>>> CreateAppRecipes(AppRecipesCreateDto dto)
        {

            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(resultDto);


            try
            {
                AppRecipes appRecipes = _mapper.Map<AppRecipes>(dto);

                //var recipeByProductVariable = await GetRecipesByProductIdVariableId((int)dto.AppproductsId, (int)dto.AppVariableId);
                //if (recipeByProductVariable != null)
                //{

                //    metadata.IsValid = false;
                //    metadata.Message = "Variable ya existe en este producto!!";
                //    response.Data = null;
                //    response.Meta = metadata;
                //    return response;
                //}


                AppProducts appProductsFind = await _appProductsService.GetById((int)dto.AppproductsId);
                if (appProductsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Producto no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                AppVariables appVariablesFind = await _appVariablesService.GetById((int)dto.AppVariableId);
                if (appVariablesFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                appRecipes.Code = appVariablesFind.Code;

                appRecipes.Description = appVariablesFind.Description;

                appRecipes.Quantity = dto.Quantity;

                appRecipes.SumValue = dto.SumValue;

                appRecipes.OrderCalculate = dto.OrderCalculate;

                appRecipes.IncludeInSearch = dto.IncludeInSearch;

                appRecipes.AfectaCosto = dto.AfectaCosto;

                appRecipes.Secuencia = dto.Secuencia;

                if (dto.AppIngredientsId!=null)
                {
                    AppIngredients appIngredientsFind = await _unitOfWork.AppIngredientsRepository.GetById((int)dto.AppIngredientsId);
                    if (appIngredientsFind == null)
                    {

                        metadata.IsValid = false;
                        metadata.Message = "Ingrediente no existe!!";
                        response.Data = null;
                        response.Meta = metadata;
                        return response;
                    }
                    else
                    {
                        if (dto.AfectaCosto == true)
                        {
                            appRecipes.TotalCost = appIngredientsFind.Cost * appRecipes.Quantity;
                        }
                        else
                        {
                            appRecipes.TotalCost = 0;
                        }

                      
                       
                    }
                }
                else
                {
                    if (dto.Formula == "" || dto.Formula==null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Debe Indicar Una formula o seleccionar un ingrediente!!";
                        response.Data = null;
                        response.Meta = metadata;
                        return response;
                    }

                    appRecipes.TotalCost = 0;
                    appRecipes.Formula = dto.Formula;
                    appRecipes.FormulaValue = "";
                }

              
                var inserted = await Insert(appRecipes);
                await UpdateVariableSearchByProduct((int)dto.AppproductsId);

                var listRecipeCalculate = await CalulateRecipeByProduct((int)dto.AppproductsId);

                response.Data = listRecipeCalculate;
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


        public async Task<AppRecipes> Update(AppRecipes appRecipes)
        {

            var appRecipesFind = await GetById(appRecipes.Id);
            if (appRecipesFind == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppRecipesRepository.Update(appRecipes);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appRecipes.Id);


        }
        public async Task<ApiResponse<List<AppRecipesGetDto>>> UpdateAppRecipes(AppRecipesUpdateDto dto)
        {

            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(resultDto);


            try
            {
               

                var recipe = await GetById(dto.Id);
                if (recipe == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Receta no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }


                AppProducts appProductsFind = await _appProductsService.GetById((int)dto.AppproductsId);
                if (appProductsFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Producto no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                AppVariables appVariablesFind = await _appVariablesService.GetById((int)dto.AppVariableId);
                if (appVariablesFind == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Variable no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                if (dto.Formula.Length > 0 )
                {
                    dto.AppIngredientsId = null;
                }


                recipe.Code = appVariablesFind.Code;

                recipe.Description = appVariablesFind.Description;

                recipe.Quantity = dto.Quantity;

                recipe.SumValue = dto.SumValue;

                recipe.OrderCalculate = dto.OrderCalculate;


                recipe.IncludeInSearch = dto.IncludeInSearch;


                recipe.AfectaCosto = dto.AfectaCosto;

                recipe.Secuencia = dto.Secuencia;

                recipe.AppIngredientsId = dto.AppIngredientsId;

                if (dto.AppIngredientsId != null)
                {
                    AppIngredients appIngredientsFind = await _unitOfWork.AppIngredientsRepository.GetById((int)dto.AppIngredientsId);
                    if (appIngredientsFind == null)
                    {

                        metadata.IsValid = false;
                        metadata.Message = "Ingrediente no existe!!";
                        response.Data = null;
                        response.Meta = metadata;
                        return response;
                    }
                    else
                    {
                        if (dto.AfectaCosto==true)
                        {
                            recipe.TotalCost = appIngredientsFind.Cost * recipe.Quantity;
                        }
                        else
                        {
                            recipe.TotalCost = 0;
                        }
                       

                    }
                }
                else
                {
                    if (dto.Formula == "" || dto.Formula == null)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Debe Indicar Una formula o seleccionar un ingrediente!!";
                        response.Data = null;
                        response.Meta = metadata;
                        return response;
                    }

                    recipe.TotalCost = 0;
                    recipe.Formula = dto.Formula;
                    recipe.FormulaValue = "";
                }


                var updated = await Update(recipe);
                await UpdateVariableSearchByProduct((int)dto.AppproductsId);
                var listRecipeCalculate = await CalulateRecipeByProduct((int)dto.AppproductsId);
                metadata.IsValid = true;
                metadata.Message = "Receta actualizada!";
                response.Data = listRecipeCalculate;
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

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppRecipesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
       
        public async Task<ApiResponse<bool>> DeleteAppRecipes(AppRecipesDeleteDto dto)
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

                AppRecipes appRecipes = await GetById(dto.Id);

                if (appRecipes == null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Receta no  No existe!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                AppRecipes recipesExistInFormula = await _unitOfWork.AppRecipesRepository.GetRecipesByCodeInFormula((int)appRecipes.AppproductsId,appRecipes.Code);

                if (recipesExistInFormula != null)
                {
                    metadata.IsValid = false;

                    metadata.Message = "Variable esta siendo usada en la formulacion!!!";

                    response.Meta = metadata;
                    response.Data = resultDto;

                    return response;
                }

                resultDto = await Delete(dto.Id);

                metadata.IsValid = true;
                metadata.Message = $"VAriable  Eliminada de la Receta Satisfactoriamente!";

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

        public async Task<AppRecipes> GetRecipesByProductIdVariableId(int productId, int variableId)
        {

            return await _unitOfWork.AppRecipesRepository.GetRecipesByProductIdVariableId(productId, variableId);

        }


        public async Task<decimal> CalculateFormula(AppRecipes recipe)
        {
            try
            {

                decimal result = 0;

    
                if (recipe == null)
                {
                    result = 0;
                }
                else
                {

                    string formula = await GetValueFormula(recipe.Formula, recipe.Appproducts.Code, recipe.Code);
                    DataTable dt = new DataTable();
                    object calculate = dt.Compute(formula, "");
                    string a = calculate.ToString();
                    result = Convert.ToDecimal(calculate.ToString());
                    recipe.Quantity = 1;
                    recipe.TotalCost = result;
                    recipe.FormulaValue = formula;
                    await Update(recipe);
                    




                }



                return result;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return 0;

            }



        }

        public async Task<string> GetValueFormula(string formula, string codeProduct, string codeRecipe)
        {

            string newFormula = "";
            
            List<string> variablesList = _helperService.GetListString(formula, "[", "]");

            newFormula = formula;
            foreach (string item in variablesList)
            {
           
                var recipe = await _unitOfWork.AppRecipesRepository.GetListRecipesByProductCodeVariableCode(codeProduct, item);
                if (recipe != null && recipe.Count>0)
                {

                    var totalCost = recipe.Select(c => c.TotalCost).Sum();

                    newFormula = newFormula.Replace("[" + item + "]", totalCost.ToString());
                }
                else
                {
                    var configApp = await _unitOfWork.AppConfigAppRepository.GetByKey(item);
                   
                    if (configApp != null)
                    {
                        newFormula = newFormula.Replace("[" + item + "]", configApp.Valor.ToString());
                    }
                }
            }


            return newFormula;

        }

       

        public async Task UpdateIngredientsCostRecipeByProduct(int productId)
        {
           

            var recipe = await _unitOfWork.AppRecipesRepository.GetRecipesWithIngredientsByProductId(productId); ;

            if (recipe == null)
            {
                return ;
            }
            else
            {
                foreach (AppRecipes item in recipe)
                {
                    var recipeItem = await GetById(item.Id);

                    if (item.AfectaCosto==true)
                    {
                        recipeItem.TotalCost = recipeItem.Quantity * item.AppIngredients.Cost;
                    }
                    else
                    {
                        recipeItem.TotalCost = 0;
                    } 

                    
                    await Update(recipeItem);
                }

               
            }


        }

        public async Task<List<AppRecipesGetDto>> CalulateRecipeByProduct(int productId)
        {

            await UpdateIngredientsCostRecipeByProduct(productId);

            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();


            AppRecipesQueryFilter filter = new AppRecipesQueryFilter();
            filter.AppproductsId = productId;
            filter.SearchText = "";
            var recipe = await GetRecipesByProductId(productId);
          
            if (recipe == null)
            {
                return resultDto;
            }
            else
            {
                foreach (AppRecipes item in recipe.OrderBy(x=>x.OrderCalculate).ToList())
                {
                    await CalculateFormula(item);
                }

                await UpdatePriceByProduct(productId);
                resultDto = await GetRecipesGetDtoByProductId(filter);
                return resultDto;
            }


        }

        public async Task UpdatePriceByProduct(int productId)
        {
            var product = await _appProductsService.GetById(productId);

            var codeProduct = product.Code;

            if (product != null)
            {
                decimal totaCostProduct = _unitOfWork.AppRecipesRepository.TotalCost(productId);

                product.UnitPrice = totaCostProduct;
                await _appProductsService.Update(product);

            }




        }

        public async Task UpdateVariableSearchByProduct(int productId)
        {

            var product = await _unitOfWork.AppProductsRepository.GetById(productId);
            if (product!=null)
            {
                var searchText = "";
                var recipe = await GetAllRecipesByProductId(productId);

                if (recipe != null)
                {

                    foreach (AppRecipes item in recipe.Where(x => x.IncludeInSearch == true).ToList())
                    {
                        var value = "";

                        AppIngredients appIngredientsFind = await _unitOfWork.AppIngredientsRepository.GetById((int)item.AppIngredientsId);
                        if (appIngredientsFind != null)
                        {
                            value = appIngredientsFind.Description.Trim();

                        }
                        else
                        {

                            AppVariables appVariablesFind = await _appVariablesService.GetById((int)item.AppVariableId);
                            if (appVariablesFind != null)
                            {
                                value = appVariablesFind.Code.Trim();

                            }

                        }

                        await _appVariableSearchService.CreateVariableSearchTextBySubcategoryVariableSearchTex((int)product.AppSubCategoryId, (int)item.AppVariableId, value);


                        searchText = searchText + item.AppVariableId.ToString().Trim() + value.Trim();

                    }
                    product.VariablesSearchText = searchText;
                    await _appProductsService.Update(product);

                }


            }

           


        }

        public async Task<ApiResponse<List<AppRecipesGetDto>>> CopyRecipes(AppCopyRecipesDto appCopyRecipesDto)
        {


            List<AppRecipesGetDto> resultDto = new List<AppRecipesGetDto>();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppRecipesGetDto>> response = new ApiResponse<List<AppRecipesGetDto>>(resultDto);

            try
            {

                var productSince = await _unitOfWork.AppProductsRepository.GetById(appCopyRecipesDto.productIdSince);
                if (productSince == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Producto desde no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
                var productUntil = await _unitOfWork.AppProductsRepository.GetById(appCopyRecipesDto.productIdUntil);
                if (productUntil == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Producto hasta no existe!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                var recipesUntil = await GetAllRecipesByProductId(productUntil.Id);
                if (recipesUntil!=null && recipesUntil.Count>0)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto hasta ya tiene una receta asociada!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                var recipes = await GetAllRecipesByProductId(productSince.Id);
                if (recipes == null )
                {
                    metadata.IsValid = false;
                    metadata.Message = "Producto desdeno tiene una receta asociada!!";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }

                foreach (var item in recipes)
                {
                    AppRecipes itemNew = new AppRecipes();

                    itemNew.AppproductsId = appCopyRecipesDto.productIdUntil;

                   

                    itemNew.AppIngredientsId = item.AppIngredientsId;
                                   

                    itemNew.AppVariableId = item.AppVariableId;

                    itemNew.Code = item.Code;

                    itemNew.Description = item.Description;

                    itemNew.Formula = item.Formula;

                    itemNew.FormulaValue = item.FormulaValue;

                    itemNew.IncludeInSearch = item.IncludeInSearch;

                    itemNew.OrderCalculate = item.OrderCalculate;

                    itemNew.Quantity = item.Quantity;

                    itemNew.SumValue = item.SumValue;

                    itemNew.TotalCost = item.TotalCost;

                    itemNew.AfectaCosto = item.AfectaCosto;

                    itemNew.Secuencia = item.Secuencia;

                    var inserted = await Insert(itemNew);

                }

                await UpdateVariableSearchByProduct((int)appCopyRecipesDto.productIdUntil);
                var listRecipeCalculate = await CalulateRecipeByProduct((int)appCopyRecipesDto.productIdUntil);

                response.Data = listRecipeCalculate;
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
        


    }
}
