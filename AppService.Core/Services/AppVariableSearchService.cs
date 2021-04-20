using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppVariableSearchService: IAppVariableSearchService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppVariableSearchService(IUnitOfWork unitOfWork,
                                        IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AppVariableSearch>> GetAll()
        {

            var variables = await _unitOfWork.AppVariableSearchRepository.GetAll();

            return variables;
        }

        public async Task<ApiResponse<List<AppVariableSearchGetDto>>> GetAllBySubCategory(int subCategory)
        {
            List<AppVariableSearchGetDto> resultDto = new List<AppVariableSearchGetDto>();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<List<AppVariableSearchGetDto>> response = new ApiResponse<List<AppVariableSearchGetDto>>(resultDto);

            var variables = await _unitOfWork.AppVariableSearchRepository.GetAllBySubCategory(subCategory);

            List<AppVariableSearchGetDto> variablesGetDto = _mapper.Map<List<AppVariableSearchGetDto>>(variables);
            foreach (var item in variablesGetDto)
            {
                var variableItem = await _unitOfWork.AppVariablesRepository.GetById((int)item.AppVariableId);
                if (variableItem!=null)
                {
                    item.VariableDescription = variableItem.Description;
                }

            }


            //var newResult =
            //from c in variablesGetDto
            //group c by new
            //{
            //    c.AppSubCategoryId,
            //    c.AppVariableId,
            //    c.SearchText,
            //} into gcs
            //select new AppVariableSearchGetDto()
            //{
            //    AppSubCategoryId = gcs.Key.AppSubCategoryId,
            //    AppVariableId = gcs.Key.AppVariableId,
            //    SearchText = gcs.Key.SearchText,
                
            //};


            //var newResult = from a in variablesGetDto
            //                group a by  a.SearchText into res
            //                select res;



           //response.Data = newResult.ToList();
            response.Data = variablesGetDto;
            metadata.IsValid = true;
            metadata.Message = "";
            response.Meta = metadata;
            return response;


        }

        public async Task<AppVariableSearch> GetById(int id)
        {
            return await _unitOfWork.AppVariableSearchRepository.GetById(id);
        }

        public async Task<AppVariableSearch> Insert(AppVariableSearch appVariableSearch)
        {


            await _unitOfWork.AppVariableSearchRepository.Add(appVariableSearch);
            await _unitOfWork.SaveChangesAsync();
            return appVariableSearch;
        }




        public async Task<AppVariableSearch> Update(AppVariableSearch appVariableSearch)
        {

            var variables = await GetById(appVariableSearch.Id);
            if (variables == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppVariableSearchRepository.Update(appVariableSearch);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appVariableSearch.Id);

        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppVariableSearchRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task CreateVariableSearchTextBySubcategoryVariableSearchTex(int appSubCategoryId, int appVariableId, string searchText)
        {

            var variable = await _unitOfWork.AppVariableSearchRepository.GetVariableSearchTextBySubcategoryVariableSearchTex(appSubCategoryId,appVariableId, searchText);
            if (variable==null)
            {
                AppVariableSearch appVariableSearch = new AppVariableSearch();
                appVariableSearch.AppVariableId = appVariableId;
                appVariableSearch.AppSubCategoryId = appSubCategoryId;
                appVariableSearch.SearchText = searchText;
                await  Insert(appVariableSearch);
            }
           
        }
       

    }
}
