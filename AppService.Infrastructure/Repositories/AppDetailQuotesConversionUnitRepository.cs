using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppDetailQuotesConversionUnitRepository: IAppDetailQuotesConversionUnitRepository
    {

        private readonly RRDContext _context;

        public AppDetailQuotesConversionUnitRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppDetailQuotesConversionUnit>> GetAll()
        {

            return await _context.AppDetailQuotesConversionUnit.ToListAsync();

        }
        public async Task<List<AppDetailQuotesConversionUnit>> GetByAppDetailQuotesId(int appDetailQuotesId)
        {

            return await _context.AppDetailQuotesConversionUnit.Where(x=> x.AppDetailQuotesId== appDetailQuotesId).ToListAsync();

        }
        public async Task<AppDetailQuotesConversionUnit> GetByAppDetailQuotesIdCode(int appDetailQuotesId,string code)
        {

            return await _context.AppDetailQuotesConversionUnit.Where(x => x.AppDetailQuotesId == appDetailQuotesId && x.Code==code).FirstOrDefaultAsync();

        }

        public async Task<AppDetailQuotesConversionUnit> GetById(int id)
        {
            return await _context.AppDetailQuotesConversionUnit.FindAsync(id);
        }

        public async Task Add(AppDetailQuotesConversionUnit entity)
        {
            await _context.AppDetailQuotesConversionUnit.AddAsync(entity);


        }



        public void Update(AppDetailQuotesConversionUnit entity)
        {
            _context.AppDetailQuotesConversionUnit.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppDetailQuotesConversionUnit entity = await GetById(id);
            _context.AppDetailQuotesConversionUnit.Remove(entity);

        }

        public decimal TotalValue(int appDetailQuotesId)
        {

            var total = (from c in _context.AppDetailQuotesConversionUnit
                         where c.AppDetailQuotesId == appDetailQuotesId && c.SumValue == true
                         select c.Value).Sum();

            return (decimal)total;
        }
        public decimal GetCantidadPorUnidadProduccion(int appDetailQuotesId)
        {

            var total = (from c in _context.AppDetailQuotesConversionUnit
                         where c.AppDetailQuotesId == appDetailQuotesId && c.Code == "CANTIDADPORUNIDAD"
                         select c.Value).FirstOrDefault();

            return (decimal)total;
        }

        public async Task<List<AppDetailQuotesConversionUnit>> GetDetailQuotesConversionInputById(int appDetailQuotesId)
        {

            return await _context.AppDetailQuotesConversionUnit.Where(x => x.AppDetailQuotesId == appDetailQuotesId && (x.Formula == null || x.Formula == "")).ToListAsync();

        }

    }
}
