using AppService.Core.EntitiesMaestros;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICsmy036Repository
    {


        Task<Csmy036> GetByCode(string codigo);


    }
}
