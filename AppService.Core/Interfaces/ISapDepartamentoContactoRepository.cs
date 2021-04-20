using AppService.Core.EntitiesSap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapDepartamentoContactoRepository
    {

        Task<List<SapDepartamentoContacto>> GetAll();
        Task<SapDepartamentoContacto> GetById(string id);
    }
}
