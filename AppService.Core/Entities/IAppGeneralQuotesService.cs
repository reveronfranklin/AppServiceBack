using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Entities
{
    public interface IAppGeneralQuotesService
    {
        Task<PagedList<AppGeneralQuotesGetDto>> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters);
        Task<ApiResponse<AppGeneralQuotesGetDto>> InsertGeneralQuotes(AppGeneralQuotesCreateDto appGeneralQuotesCreateDto);
        Task<ApiResponse<AppGeneralQuotesGetDto>> UpdateGeneralQuotes(AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto);
        Task<ApiResponse<bool>> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto);
        Task<ApiResponse<AppGeneralQuotesGetDto>> EnviarAlCliente(AppGeneralQuotesChangeStatusDto dto);
        Task<AppGeneralQuotesActionSheetDto> GetAppGeneralQuotesActionSheetDto(int AppGeneralQuotesId);
      
    }
}
