using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppGeneralQuotesRepository
    {

        Task<List<AppGeneralQuotes>> GetAll(AppGeneralQuotesQueryFilter filter);

        Task<AppGeneralQuotes> GetById(int id);

        Task<AppGeneralQuotes> GetByCotizacions(string cotizacion);

        Task Add(AppGeneralQuotes entity);

        void Update(AppGeneralQuotes entity);

        Task Delete(int id);

        string ProximaCotizacion(string Cod_Vendedor);
        
        Task<bool> PermiteAdicionarDetalle(int idGeneralQuote);


        Task<bool> VerificarStatus(int idGeneralQuote);



    }
}
