using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class PropuestaRepository: IPropuestaRepository
    {

        private readonly MooreveContext _context;

        public PropuestaRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy515>> GetAll()
        {

            return await _context.Wsmy515.ToListAsync();

        }




        public async Task<Wsmy515> GetById(decimal id)
        {
            return await _context.Wsmy515.FindAsync(id);
        }

        public async Task<List<Wsmy515>> GetByCotizacion(string cotizacion)
        {
            return await _context.Wsmy515.Where(x => x.Cotizacion == cotizacion).ToListAsync();
        }

        public async Task<List<Wsmy515>> GetByCotizacionRenglon(string cotizacion, int renglon)
        {
            return await _context.Wsmy515.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon).ToListAsync();
        }

        public async Task<Wsmy515> GetByCotizacionRenglonPropuesta(string cotizacion, int renglon,int propuesta)
        {
            return await _context.Wsmy515.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta==propuesta).FirstOrDefaultAsync();
        }

        public async Task Add(Wsmy515 entity)
        {
            await _context.Wsmy515.AddAsync(entity);


        }



        public void Update(Wsmy515 entity)
        {
            _context.Wsmy515.Update(entity).Property(x => x.Id).IsModified = false;

        }

        public async Task Delete(string cotizacion, int renglon, int propuesta)
        {
            Wsmy515 entity = await GetByCotizacionRenglonPropuesta(cotizacion, renglon, propuesta);
            _context.Wsmy515.Remove(entity);

        }

    }
}
