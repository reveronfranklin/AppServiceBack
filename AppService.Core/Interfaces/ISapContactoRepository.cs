using AppService.Core.EntitiesSap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapContactoRepository
    {
        Task<SapContactos> GetById(decimal id);
        Task Add(SapContactos entity);
        void Update(SapContactos entity);
        Task Delete(decimal id);
        Task<decimal> NextId();



    }
}
