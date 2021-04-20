﻿using AppService.Core.EntitiesMooreve;
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
    public class Wpry241Repository: IWpry241Repository
    {

        private readonly MooreveContext _context;

        public Wpry241Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wpry241>> GetAll()
        {

            return await _context.Wpry241.ToListAsync();

        }

        public async Task<Wpry241> GetById(int id)
        {

            return await _context.Wpry241.Where(x => x.Recnum==id).FirstOrDefaultAsync();
        }

        public async Task<List<Wpry241>> GetByCotizacionRenglonPropuestaParteTinta(string cotizacion, int renglon, int propuesta, int parte,string idTinta)
        {

            return await _context.Wpry241.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta == propuesta && x.IdParte == parte && x.IdTinta==idTinta).ToListAsync();
        }

        public async Task<List<Wpry241>> GetByCotizacion(string cotizacion)
        {

            return await _context.Wpry241.Where(x => x.Cotizacion == cotizacion ).ToListAsync();
        }

        public async Task Add(Wpry241 entity)
        {
            await _context.Wpry241.AddAsync(entity);


        }



        public void Update(Wpry241 entity)
        {
            _context.Wpry241.Update(entity).Property(x => x.Recnum).IsModified = false; ;

        }
        public async Task Delete(int id)
        {
            Wpry241 entity = await GetById(id);
            _context.Wpry241.Remove(entity);

        }


       




    }
}
