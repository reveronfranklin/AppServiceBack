using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppVariableSearchService
    {

        Task<List<AppVariableSearch>> GetAll();

        Task<ApiResponse<List<AppVariableSearchGetDto>>> GetAllBySubCategory(int subCategory);

        Task<AppVariableSearch> GetById(int id);

        Task<AppVariableSearch> Insert(AppVariableSearch appVariableSearch);


        Task<AppVariableSearch> Update(AppVariableSearch appVariableSearch);


        Task<bool> Delete(int id);

        Task CreateVariableSearchTextBySubcategoryVariableSearchTex(int appSubCategoryId, int appVariableId, string searchText);


    }
}
