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
    public class AprobacionesRepository: IAprobacionesRepository
    {

        private readonly MooreveContext _context;

        public AprobacionesRepository(MooreveContext context)
        {
            _context = context;
        }

    


        public async Task<List<Wsmy639>> GetAll()
        {

            return await _context.Wsmy639.ToListAsync();

        }




        public async Task<Wsmy639> GetById(long id)
        {
            return await _context.Wsmy639.FindAsync(id);
        }

        public async Task<Wsmy639> GetByCotizacionRenglonPropuesta(string cotizacion,int renglon,int propuesta)
        {
            return await _context.Wsmy639.Where(x => x.Cotizacion == cotizacion && x.Renglon==renglon && x.Propuesta==propuesta).FirstOrDefaultAsync();
        }

        public async Task Add(Wsmy639 entity)
        {


            try
            {
                if (entity.Id==0)
                {
                    entity.Id = await NextId();
                }

                await _context.Wsmy639.AddAsync(entity);
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                
            }
            


        }



        public void Update(Wsmy639 entity)
        {
            _context.Wsmy639.Update(entity).Property(x => x.RecNum).IsModified = false; ;

        }

        public async Task Delete(long id)
        {
            Wsmy639 entity = await GetById(id);
            _context.Wsmy639.Remove(entity);

        }

        public async Task<long> NextId()
        {
            var ultimo = await _context.Wsmy639.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return ultimo.Id + 1;


        }


    }
}
