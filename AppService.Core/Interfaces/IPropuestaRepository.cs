using AppService.Core.EntitiesMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IPropuestaRepository
    {


        Task<List<Wsmy515>> GetAll();

        Task<Wsmy515> GetById(decimal id);

        Task<List<Wsmy515>> GetByCotizacion(string cotizacion);

        Task<List<Wsmy515>> GetByCotizacionRenglon(string cotizacion, int renglon);

        Task<Wsmy515> GetByCotizacionRenglonPropuesta(string cotizacion, int renglon, int propuesta);

        Task Add(Wsmy515 entity);

        void Update(Wsmy515 entity);

        Task Delete(string cotizacion, int renglon, int propuesta);





    }
}
