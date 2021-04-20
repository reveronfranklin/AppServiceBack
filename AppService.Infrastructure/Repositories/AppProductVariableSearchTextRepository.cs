using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppProductVariableSearchTextRepository: IAppProductVariableSearchTextRepository
    {
        private readonly RRDContext _context;

        public AppProductVariableSearchTextRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppProductVariableSearchText>> GetAll()
        {

            return await _context.AppProductVariableSearchText.ToListAsync();

        }
        public async Task<List<AppProductVariableSearchText>> GetAllByListVariable(List<AppVariableSearchCompareQueryFilter> filter)
        {

            try
            {
                /*List<AppProductVariableSearchText> result = new List<AppProductVariableSearchText>();
                foreach (var item in filter)
                {
                    List<AppProductVariableSearchText> resultItem = new List<AppProductVariableSearchText>();

                    resultItem = await _context.AppProductVariableSearchText.Where(x => x.AppVariableId == item.AppVariableId && x.SearchText == item.SearchText).ToListAsync();
                    if (resultItem!= null)
                    {
                        result.AddRange(resultItem);
                    }

                }*/
                var variables = await _context.AppProductVariableSearchText.ToListAsync();
                var filtered = variables.Where(x => filter.ToList().Exists(y => y.AppVariableId == x.AppVariableId && y.SearchText == x.SearchText)).ToList();



               
                //var filtered2 =  variables.Where(o => filter.Contains(o)).ToList();


                return filtered;
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message;
                return null;
            }
           

        }

        public async Task<AppProductVariableSearchText> GetById(int id)
        {
            return await _context.AppProductVariableSearchText.FindAsync(id);
        }


        public async Task Add(AppProductVariableSearchText entity)
        {
            await _context.AppProductVariableSearchText.AddAsync(entity);


        }



        public void Update(AppProductVariableSearchText entity)
        {
            _context.AppProductVariableSearchText.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppProductVariableSearchText entity = await GetById(id);
            _context.AppProductVariableSearchText.Remove(entity);

        }

    }
}
