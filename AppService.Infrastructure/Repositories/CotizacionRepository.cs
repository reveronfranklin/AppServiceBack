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
    public class CotizacionRepository: ICotizacionRepository
    {
        private readonly MooreveContext _context;

        public CotizacionRepository(MooreveContext context)
        {
            _context = context;
        }

        public string ProximaCotizacion(string Cod_Vendedor)
        {

            try
            {
                string ProximaCotizacion = "";
                string vendededor = Cod_Vendedor.ToUpper();
                string año = DateTime.Now.Year.ToString();
                string mes = DateTime.Now.Month.ToString().PadLeft(2, '0');

                ProximaCotizacion = $"{vendededor}{año}{mes}";
                var query = $"SELECT Max(Proximo) as Proximo From (select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501 where substring(cotizacion,1,10) = '{ProximaCotizacion}' UNION ALL select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501Log where substring(cotizacion,1,10) = '{ProximaCotizacion}') as Detalle";

                //var query = $"SELECT Max(Proximo) as Proximo From (select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  AppGeneralQuotes where substring(cotizacion,1,10) = '{ProximaCotizacion}' UNION ALL select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  AppGeneralQuotes where substring(cotizacion,1,10) = '{ProximaCotizacion}') as Detalle";


                var result = _context.Wsmy501.FromSqlRaw(query).Select(b => new {
                    Proximo = b.Proximo
                }).FirstOrDefault();

                var siguiente = result.Proximo + 1;
                var proximoString = siguiente.ToString();
                proximoString = proximoString.ToString().PadLeft(3, '0');
                ProximaCotizacion = ProximaCotizacion + proximoString;

                return ProximaCotizacion;
            }
            catch (Exception e)
            {
                string ProximaCotizacion = "";

                ProximaCotizacion = e.Message;
                return ProximaCotizacion;

            }


            
        }


        public async Task<List<Wsmy501>> GetAll()
        {

            return await _context.Wsmy501.ToListAsync();

        }


     

        public async Task<Wsmy501> GetById(int id)
        {
            return await _context.Wsmy501.FindAsync(id);
        }

        public async Task<Wsmy501> GetByCotizacion(string cotizacion)
        {
            try
            {
                var cotizacionFind = await _context.Wsmy501.Where(x => x.Cotizacion == cotizacion).FirstOrDefaultAsync();
                return cotizacionFind;
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }

          
        }
        
        public async Task Add(Wsmy501 entity)
        {
            await _context.Wsmy501.AddAsync(entity);


        }



        public void Update(Wsmy501 entity)
        {


            
            _context.Wsmy501.Update(entity).Property(x => x.Id).IsModified = false; 

        }

        public async Task Delete(string id)
        {
            Wsmy501 entity = await GetByCotizacion(id);
            _context.Wsmy501.Remove(entity);

        }

    }
}
