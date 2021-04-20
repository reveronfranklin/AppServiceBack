using AppService.Core.EntitiesFacturacion;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWiny243Repository
    {

        Task<Winy243> GetByEstadoMunicipio(string estado, string municipio);

        Task<List<Winy243>> GetAllFilter(MunicipioQueryFilter filter);

        Task<Winy243> GetById(decimal id);
    }
}
