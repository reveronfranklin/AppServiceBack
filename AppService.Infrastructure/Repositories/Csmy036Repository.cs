using AppService.Core.EntitiesMaestros;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMaestros;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Csmy036Repository: ICsmy036Repository
    {

        private readonly MaestrosContext _context;

        public Csmy036Repository(MaestrosContext context)
        {
            _context = context;
        }


        public async Task<Csmy036> GetByCode(string codigo)
        {
            Csmy036 result = new Csmy036();
            try
            {
                result= await _context.Csmy036.Where(x => x.CodigoProduct == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }


            
        }

    }
}
