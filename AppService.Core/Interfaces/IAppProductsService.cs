using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductsService
    {

        Task<List<AppProducts>> GetAll();

        Task<AppProducts> GetById(int id);

        Task<AppProducts> Insert(AppProducts appProducts);

        Task<AppProducts> Update(AppProducts appProducts);

        Task<bool> Delete(short id);
        Task<ApiResponse<bool>> DeleteProduct(AppProductsDeleteDto dto);

        Task<ApiResponse<List<AppProductsGetDto>>> GetAll(AppProdutsQueryFilter filters);
        Task<ApiResponse<AppProductsGetDto>> UpdateProducts(AppProductsUpdateDto appProductsUpdateDto);
        Task<ApiResponse<AppProductsGetDto>> InsertProducts(AppProductsCreateDto appProductsCreateDto);
        Task<ApiResponse<List<AppProductsGetDto>>> GetAllByVariable(List<AppVariableSearchCompareQueryFilter> filter);
        Task<ApiResponse<AppProductsGetDto>> GetProduct(int id);
    }
}
