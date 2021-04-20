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
    public class AppRecipesRepository: IAppRecipesRepository
    {

        private readonly RRDContext _context;

        public AppRecipesRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppRecipes>> GetAll()
        {

            return await _context.AppRecipes.ToListAsync();

        }
        public async Task<AppRecipes> GetRecipesByCodeInFormula(int appproductsId,string code)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.AppproductsId==appproductsId && x.Formula.Trim().ToLower().Contains(code.Trim().ToLower()) ).FirstOrDefaultAsync();
        }

        public async Task<List<AppRecipes>> GetRecipesByProductId( int productId)
        {

            return await _context.AppRecipes.Include(x=> x.Appproducts).Where(x=>x.AppproductsId== productId && x.Formula.Length > 0).OrderBy(x=>x.OrderCalculate).ToListAsync();

        }
        public async Task<List<AppRecipes>> GetAllRecipesByProductId(int productId)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.AppproductsId == productId ).OrderBy(x => x.OrderCalculate).ToListAsync();

        }
        public async Task<List<AppRecipes>> GetRecipesWithIngredientsByProductId(int productId)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Include(x=>x.AppIngredients).Where(x => x.AppproductsId == productId && x.AppIngredientsId > 0).OrderBy(x => x.OrderCalculate).ToListAsync();

        }

        public async Task<AppRecipes> GetRecipesByProductIdVariableId(int productId,int variableId)
        {

            return await _context.AppRecipes.Where(x => x.AppproductsId == productId && x.AppVariableId== (int)variableId).FirstOrDefaultAsync();

        }
        public async Task<AppRecipes> GetRecipesByProductCodeVariableCode(string codeProduct, string code)
        {

            return await _context.AppRecipes.Where(x => x.Appproducts.Code == codeProduct && x.Code == code).FirstOrDefaultAsync();

        }
        public async Task<List<AppRecipes>> GetListRecipesByProductCodeVariableCode(string codeProduct, string code)
        {

            return await _context.AppRecipes.Where(x => x.Appproducts.Code == codeProduct && x.Code == code).ToListAsync();

        }

        public async Task<List<AppRecipes>> GetListRecipesByProductIdVariableCode(int idProduct, string code)
        {

            return await _context.AppRecipes.Where(x => x.AppproductsId == idProduct && x.Code == code).ToListAsync();

        }

        public async Task<AppRecipes> GetRecipesByVariableCode(string code)
        {

            return await _context.AppRecipes.Where(x => x.Code == code).FirstOrDefaultAsync();

        }
        public async Task<AppRecipes> GetRecipesByIdIngredients(int id)
        {

            return await _context.AppRecipes.Where(x => x.AppIngredientsId == id).FirstOrDefaultAsync();

        }
        public async Task<List<AppRecipes>> GetListRecipesByIdIngredients(int id)
        {

            return await _context.AppRecipes.Where(x => x.AppIngredientsId == id).ToListAsync();

        }

        public async Task<AppRecipes> GetById(int id)
        {
            return await _context.AppRecipes.FindAsync(id);
        }

        public async Task Add(AppRecipes entity)
        {
            await _context.AppRecipes.AddAsync(entity);


        }



        public void Update(AppRecipes entity)
        {
            _context.AppRecipes.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppRecipes entity = await GetById(id);
            _context.AppRecipes.Remove(entity);

        }

        public decimal TotalCost(int productId)
        {

            var  totaCostProduct = (from c in _context.AppRecipes
                                       where c.AppproductsId == productId && c.SumValue == true
                                       select c.TotalCost).Sum();

            return (decimal)totaCostProduct;
        }


    }
}
