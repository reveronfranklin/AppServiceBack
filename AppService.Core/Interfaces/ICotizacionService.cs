using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICotizacionService
    {

        Task<List<Wsmy501>> GetAll();


        Task<Wsmy501> GetById(int id);

        Task<Wsmy501> GetByCotizacion(string cotizacion);

        Task<Wsmy501> Insert(Wsmy501 cotizacion);

        Task<ApiResponse<CotizacionGetDto>> CreateCotizacion(CotizacionCreateDto dto);

        Task<Wsmy501> Update(Wsmy501 cotizacion);

        Task<ApiResponse<CotizacionGetDto>> UpdateCotizacion(CotizacionUpdateDto dto);

        Task<bool> Delete(string cotizacion);

        Task<ApiResponse<bool>> DeleteCotizacionOld(CotizacionDeleteDtocs dto);
        Task DeleteCotizacion(AppGeneralQuotes appGeneralQuotes);

        Task IntegrarCotizacion(int generalQuotesId);

        Task DeleteCotizacionRenglon(AppDetailQuotes appDetailQuotes);
        
        Task updateMedidas();

    }
}
