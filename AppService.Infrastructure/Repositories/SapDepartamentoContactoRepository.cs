using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapDepartamentoContactoRepository: ISapDepartamentoContactoRepository
    {

        private readonly SapContext _context;

        public SapDepartamentoContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<List<SapDepartamentoContacto>> GetAll()
        {

            return await _context.SapDepartamentoContacto.ToListAsync();

        }
        public async Task<SapDepartamentoContacto> GetById(string id)
        {
            return await _context.SapDepartamentoContacto.Where(x=> x.Codigo==id).FirstOrDefaultAsync();
        }
    }
}
