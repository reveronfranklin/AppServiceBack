using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobEstadoCuentaService
    {
        Task<PagedList<CobEstadoDeCuenta>> GetEstadoCuenta(CobEstadoCuentaQueryFilter filters);
        Task<CobEstadoDeCuenta> GetEstadoCuentaById(decimal id);
    }
}
