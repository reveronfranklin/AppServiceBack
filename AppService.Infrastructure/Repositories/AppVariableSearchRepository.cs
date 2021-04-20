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
    public class AppVariableSearchRepository: IAppVariableSearchRepository
    {

        private readonly RRDContext _context;

        public AppVariableSearchRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppVariableSearch>> GetAll()
        {

            return await _context.AppVariableSearch.ToListAsync();

        }
        public async Task<List<AppVariableSearch>> GetAllBySubCategory(int appSubCategoryId)
        {

            return await _context.AppVariableSearch.Where(x=> x.AppSubCategoryId== appSubCategoryId).ToListAsync();

        }

        public async Task<AppVariableSearch> GetById(int id)
        {
            return await _context.AppVariableSearch.FindAsync(id);
        }
      

        public async Task Add(AppVariableSearch entity)
        {
            await _context.AppVariableSearch.AddAsync(entity);


        }



        public void Update(AppVariableSearch entity)
        {
            _context.AppVariableSearch.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppVariableSearch entity = await GetById(id);
            _context.AppVariableSearch.Remove(entity);

        }


        public async Task<AppVariableSearch> GetVariableSearchTextBySubcategoryVariableSearchTex(int appSubCategoryId,int appVariableId, string searchText)
        {

            var variable= await _context.AppVariableSearch.Where(x => x.AppSubCategoryId == appSubCategoryId && x.AppVariableId== appVariableId && x.SearchText== searchText).FirstOrDefaultAsync();
            return variable;

        }






    }
}
