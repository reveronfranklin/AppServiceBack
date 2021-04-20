using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrClienteRepository : IMtrClienteRepository
    {
        private readonly RRDContext _context;

        public MtrClienteRepository(RRDContext context) 
        {
            _context = context;
        }

        public IEnumerable<MtrCliente> GetAll(string usuario)
        {

            return _context.MtrCliente.AsEnumerable();

        }

        public async Task<MtrCliente> GetByIdAsync(string id)
        {

            return await _context.MtrCliente.Where(x=> x.Codigo==id).FirstOrDefaultAsync();

        }

        public MtrCliente GetById(string id)
        {

            return  _context.MtrCliente.Where(x => x.Codigo == id).FirstOrDefault();

        }

        public async Task<IEnumerable<MtrCliente>> ListClientesPorUsuario(MtrClienteQueryFilter filter)
        {
            List<MtrCliente> result = new List<MtrCliente>();
            string usuario = filter.Usuario;
            int pageSize = filter.PageSize;

            var vendedor = await _context.MtrVendedor.Where(x => x.Codigo == usuario).FirstOrDefaultAsync();
            if (vendedor!=null)
            {


                if (filter.Codigo != null && filter.Codigo.Length > 0)
                {
                    result = await _context.MtrCliente.Where(x => x.Vendedor1 == usuario && x.FlagInactivo != "X" && ((x.Codigo.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower())) || (x.NoRegTribut.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower())) || (x.Nombre.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower()))) ).OrderBy(x => x.Nombre).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }
                else
                {
                    result = await _context.MtrCliente.Where(x => x.Vendedor1 == usuario && x.FlagInactivo != "X").OrderBy(x => x.Nombre).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                }
                var clieProspecto = await _context.MtrCliente.Where(x => x.Codigo == "000000").ToListAsync();
                result.AddRange(clieProspecto);
                return result;


            }

            var supervisor = await _context.MtrVendedor.Where(x => x.Supervisor == usuario).FirstOrDefaultAsync();
            if (supervisor != null)
            {

                result = await (from u in _context.MtrCliente
                                     join ur in _context.MtrVendedor on u.Vendedor1 equals ur.Codigo
                                    
                                     where ur.Supervisor == usuario & u.FlagInactivo !="X" 
                                     select u).ToListAsync();

            }

          

            var usuarioOficina = await _context.MtrUsuarioOficina.Where(x => x.Usuario == usuario).ToListAsync();
            if (usuarioOficina.Count > 0 )
            {
                if (filter.Codigo != null && filter.Codigo.Length > 0)
                {
                   
                        var clie = await _context.MtrCliente.Where(x =>  x.FlagInactivo != "X" && ((x.Codigo.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower()))  || (x.NoRegTribut.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower())) || (x.Nombre.Trim().ToLower().Contains(filter.Codigo.Trim().ToLower())))  ).OrderBy(x => x.Nombre).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                        result.AddRange(clie);
                        //foreach (var itemcli in clie)
                        //{
                        //    result.Add(itemcli);
                        //}

                    

                }
                else
                {
                   
                        var clie = await _context.MtrCliente.Where(x => x.FlagInactivo != "X").OrderBy(x=>x.Nombre).Skip((filter.PageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                        result.AddRange(clie);
                        //foreach (var itemcli in clie)
                        //{
                        //    result.Add(itemcli);
                        //}

                   
                }


              
            }

            if (filter.Oficina!= null)
            {
                result =result.Where(x => x.OficinaVenta.Trim() == filter.Oficina.Trim()).ToList();
            }
            if (filter.Vendedor != null)
            {
                result = result.Where(x => x.Vendedor1.ToLower().Trim() == filter.Vendedor.ToLower().Trim()).ToList();
            }

            var clieProspectoNew = await _context.MtrCliente.Where(x =>  x.Codigo== "000000").ToListAsync();
            result.AddRange(clieProspectoNew);

            return result;

        }

    }
}
