using AppService.Core.EntitiesMaestros;
using AppService.Core.EntitiesMooreve;
using AppService.Infrastructure.DataMaestros;
using AppService.Infrastructure.DataMooreve;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wppy022Reposytory
    {

        private readonly MaestrosContext _context;
        public Wppy022Reposytory(MaestrosContext context)
        {
            _context = context;
        }


     

        public async Task<Wppy022> GetById(int id)
        {

            return await _context.Wppy022.FindAsync(id);
        }


    }
}
