﻿using AppService.Core.Entities;
using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppGeneralQuotesRepository: IAppGeneralQuotesRepository
    {

        private readonly RRDContext _context;
        private readonly MooreveContext _mooreveContext;

        public AppGeneralQuotesRepository(RRDContext context, MooreveContext mooreveContext)
        {
            _context = context;
            _mooreveContext = mooreveContext;
        }

        public async Task<List<AppGeneralQuotes>> GetAll(AppGeneralQuotesQueryFilter filter)
        {


            bool esVendedor = false;
            MtrVendedor vendedor = await _context.MtrVendedor.Where(x => x.Codigo == filter.UsuarioConectado).FirstOrDefaultAsync();
            if (vendedor != null)
            {
                esVendedor = true;

            }

            List<AppGeneralQuotes> result = new List<AppGeneralQuotes>();


            try
            {


                

                if (esVendedor)
                {
                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {
                        result = await _context.AppGeneralQuotes.Where(x => x.IdVendedor == filter.UsuarioConectado.ToString() &&  x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Cotizacion != null && filter.Cotizacion.Length > 0)
                    {
                        result = await _context.AppGeneralQuotes.Where(x => x.IdVendedor == filter.UsuarioConectado.ToString() && x.Cotizacion.Trim() == filter.Cotizacion.Trim()).OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else
                    {
                        result = await _context.AppGeneralQuotes.Where(x => x.IdVendedor == filter.UsuarioConectado.ToString()).OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                }
                else
                {
                    if (filter.SearchText != null && filter.SearchText.Length > 0)
                    {
                        result = await _context.AppGeneralQuotes.Where(x => x.SearchText.Trim().ToLower().Contains(filter.SearchText.Trim().ToLower())).OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else if (filter.Cotizacion != null && filter.Cotizacion.Length > 0)
                    {
                        result = await _context.AppGeneralQuotes.Where(x => x.Cotizacion.Trim() == filter.Cotizacion.Trim()).OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                    else
                    {
                        result = await _context.AppGeneralQuotes.OrderByDescending(x => x.Fecha).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToListAsync();

                    }
                }

               


                return result;

            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                return result;
            }

            

        }

        public async Task<AppGeneralQuotes> GetById(int id)
        {

            AppGeneralQuotes result = new AppGeneralQuotes();
            try
            {
                result = await _context.AppGeneralQuotes.Include(x => x.IdEstatusNavigation)
                                                         .Include(x => x.AppDetailQuotes)
                                                         .Include(x => x.IdClienteNavigation)
                                                         .Where(x => x.Id == id).FirstOrDefaultAsync(); ;
                return result;

            }
            catch (Exception e)
            {
                var mesg = e.InnerException.Message;

                return null;         
            }

          

           
        }

        public async Task<AppGeneralQuotes> GetByCotizacions(string cotizacion)
        {
            return await _context.AppGeneralQuotes.Where(x=> x.Cotizacion== cotizacion).FirstOrDefaultAsync();
        }

        public async Task Add(AppGeneralQuotes entity)
        {
            await _context.AppGeneralQuotes.AddAsync(entity);


        }



        public void Update(AppGeneralQuotes entity)
        {
             _context.AppGeneralQuotes.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppGeneralQuotes entity = await GetById(id);
            _context.AppGeneralQuotes.Remove(entity);

        }


        public string ProximaCotizacion(string Cod_Vendedor)
        {

            try
            {
                string ProximaCotizacion = "";
                string vendededor = Cod_Vendedor.ToUpper();
                string año = DateTime.Now.Year.ToString();
                string mes = DateTime.Now.Month.ToString().PadRight(2, '0');

                ProximaCotizacion = $"{vendededor}{año}{mes}";
                //var query = $"SELECT Max(Proximo) as Proximo From (select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501 where substring(cotizacion,1,10) = '{ProximaCotizacion}' UNION ALL select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501Log where substring(cotizacion,1,10) = '{ProximaCotizacion}') as Detalle";

                var query = $"SELECT Max(Proximo) as Proximo From (select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  AppGeneralQuotes where substring(cotizacion,1,10) = '{ProximaCotizacion}' UNION ALL select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  AppGeneralQuotes where substring(cotizacion,1,10) = '{ProximaCotizacion}') as Detalle";


                var result = _context.AppGeneralQuotes.FromSqlRaw(query).Select(b => new {
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

         
            /* Dim Dt New ClsDB.clsDB
        Cnn.Conectar(ClsDB.clsDB.BasesDeDatos.Mooreve, My.Settings.Servidor, ClsDB.clsDB.Seguridad.SQL, Var_UsuarioConectar, Var_ClaveConectar)
        New SqlCommand("SELECT Max(Proximo) as Proximo From (select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501 where substring(cotizacion,1,10) = '" & ProximaCotizacion & "' UNION ALL select isnull(cast(max(substring(cotizacion,11,3))  as integer),0) as Proximo from  wsmy501Log where substring(cotizacion,1,10) = '" & ProximaCotizacion & "') as Detalle", Cnn.Conexion)
            Dim Da SqlDataAdapter(Cmd)
            Da.Fill(Dt)
        Catch ex             Me.Var_Excepcion = ex.Message
        Dt.Rows.Count > 0 Then
                Proximo = Format(Dt.Rows(0).Item(0) + 1, "000")
                ProximaCotizacion = ProximaCotizacion + Proximo
            Dt = Nothing
        Cnn.Desconectar()
        Cnn = Nothing*/
        }



        public async Task<bool> PermiteAdicionarDetalle(int idGeneralQuote)
        {

            bool result = new bool();

            var detail = await _context.AppDetailQuotes.Where(x=>x.AppGeneralQuotesId == idGeneralQuote).ToListAsync();
            if (detail==null || detail.Count==0)
            {
                result= true;
            }
            else
            {
                foreach (var item in detail)
                {

                    var appProducts = await _context.AppProducts.Where(x => x.Id == item.IdProducto).FirstOrDefaultAsync();
                    if (appProducts!=null)
                    {
                        if (appProducts.AceptaMultiplesItem==true)
                        {
                            result = true;
                        }
                        else
                        {
                            return  false;
                        }
                    }

                }
            }


            return result;
        }


        public async Task<bool> VerificarStatus(int idGeneralQuote)
        {

            bool result = new bool();
            result = false;
            var generalQuotes=  await GetById(idGeneralQuote);
            if (generalQuotes!=null)
            {

                var cotizacion = await _mooreveContext.Wsmy501.Where(x => x.Cotizacion == generalQuotes.Cotizacion).FirstOrDefaultAsync();

                if (cotizacion!=null)
                {
                    if (generalQuotes.IdEstatus>cotizacion.Estatus)
                    {
                        result = true;
                        generalQuotes.IdEstatus = (int)cotizacion.Estatus;

                        Update(generalQuotes);


                        var detailQuotes = await _context.AppDetailQuotes.Where(x => x.AppGeneralQuotesId == idGeneralQuote).ToListAsync();
                        if (detailQuotes.Count>0)
                        {

                            foreach (var item in detailQuotes)
                            {
                                item.IdEstatus = generalQuotes.IdEstatus;
                                _context.AppDetailQuotes.Update(item);
                            }

                        }

                    }

                }


            }






            return result;


        }
    }
}
