using AppService.Core.EntitiesSap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapPoderContactoRepository
    {


        Task<List<SapPoderContacto>> GetAll();
        Task<SapPoderContacto> GetById(string id);
    }
}
