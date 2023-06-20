using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppRecipesRepository : IAppRecipesRepository
    {

        private readonly RRDContext _context;

        public AppRecipesRepository(RRDContext context)
        {
            _context = context;
        }
        public async Task<bool> ProductoRecibeEntrada(int appProductId)
        {
            bool result = false;
            if (await this._context.AppRecipes.Where<AppRecipes>((Expression<Func<AppRecipes, bool>>)(x => x.AppproductsId == (int?)appProductId && x.EsVariableDeEntrada == (bool?)true)).FirstOrDefaultAsync<AppRecipes>() != null)
                result = true;
            return result;
        }
        public async Task<List<AppRecipes>> GetRecipesByCategoryId(int categoryId) => await this._context.AppRecipes.Include<AppRecipes, AppProducts>((Expression<Func<AppRecipes, AppProducts>>)(x => x.Appproducts)).Where<AppRecipes>((Expression<Func<AppRecipes, bool>>)(x => x.Appproducts.AppSubCategoryId == (int?)categoryId)).OrderBy<AppRecipes, Decimal?>((Expression<Func<AppRecipes, Decimal?>>)(x => x.OrderCalculate)).ToListAsync<AppRecipes>();


        public async Task<List<AppRecipes>> GetListRecipesByCodeInFormula(string code)
        {
            var recipes = await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.Formula.Trim().ToLower().Contains(code.Trim().ToLower())).ToListAsync();
            return recipes;

        }

        public async Task<List<AppRecipes>> GetRecipesByCategoryIdIncludeInSearch(int categoryId)
        {
            var recipes = await _context.AppRecipes.Include(x => x.Appproducts).Include(x => x.AppVariable).Where(x => x.IncludeInSearch == true && x.Appproducts.AppSubCategoryId == (int)categoryId).ToListAsync();
            return recipes;
        }
        public async Task<List<AppRecipes>> GetAll()
        {

            return await _context.AppRecipes.ToListAsync();

        }
        public async Task<AppRecipes> GetRecipesByCodeInFormula(int appproductsId, string code)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.AppproductsId == appproductsId && x.Formula.Trim().ToLower().Contains(code.Trim().ToLower())).FirstOrDefaultAsync();
        }
        public async Task<AppRecipes> GetRecipesByProductIdCode(int appproductsId, string code)
        {
            return await this._context.AppRecipes.Include<AppRecipes, AppProducts>((Expression<Func<AppRecipes, AppProducts>>)(x => x.Appproducts)).Where<AppRecipes>((Expression<Func<AppRecipes, bool>>)(x => x.AppproductsId == (int?)appproductsId && x.Code == code)).FirstOrDefaultAsync<AppRecipes>();
        }

        public async Task<List<AppRecipes>> GetRecipesByProductId(int productId)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.AppproductsId == productId && x.Formula.Length > 0).OrderBy(x => x.OrderCalculate).ToListAsync();

        }
        public async Task<List<AppRecipes>> GetAllRecipesByProductId(int productId)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Where(x => x.AppproductsId == productId).OrderBy(x => x.OrderCalculate).ToListAsync();

        }
        public async Task<List<AppRecipes>> GetRecipesWithIngredientsByProductId(int productId)
        {

            return await _context.AppRecipes.Include(x => x.Appproducts).Include(x => x.AppIngredients).Where(x => x.AppproductsId == productId && x.AppIngredientsId > 0).OrderBy(x => x.OrderCalculate).ToListAsync();

        }

        public async Task<AppRecipes> GetRecipesByProductIdVariableId(int productId, int variableId)
        {

            return await _context.AppRecipes.Where(x => x.AppproductsId == productId && x.AppVariableId == (int)variableId).FirstOrDefaultAsync();

        }
        public async Task<AppRecipes> GetRecipesByProductCodeVariableCode(string codeProduct, string code)
        {

            return await _context.AppRecipes.Where(x => x.Appproducts.Code == codeProduct && x.Code == code).FirstOrDefaultAsync();

        }
        public async Task<List<AppRecipes>> GetListRecipesByProductCodeVariableCode(string codeProduct, string code)
        {

            return await _context.AppRecipes.Where(x => x.Appproducts.Code == codeProduct && x.Code == code).ToListAsync();

        }

        //public async Task<List<AppRecipes>> GetListRecipesByProductIdVariableCode(int idProduct, string code)
        //{

        //    return await _context.AppRecipes.Where(x => x.AppproductsId == idProduct && x.Code == code).ToListAsync();

        //}
        public async Task<List<AppRecipes>> GetListRecipesByProductIdVariableCode(
  int idProduct,
  string code)
        {
            "PAPELCUARTAPARTE".Substring(0, code.Length);
            return await this._context.AppRecipes.Where<AppRecipes>((Expression<Func<AppRecipes, bool>>)(x => x.AppproductsId == (int?)idProduct && x.Code.Substring(0, code.Length) == code)).ToListAsync<AppRecipes>();
        }

        public async Task<AppRecipes> GetOneRecipesByProductIdVariableCode(int idProduct, string code)
        {

            return await this._context.AppRecipes.Where(x => x.AppproductsId == (int?)idProduct && x.Code == code).FirstOrDefaultAsync();
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

            if (entity.RetornarElMayor==null) {
                entity.RetornarElMayor = false;
            }
            if (entity.RetornarElMenor == null)
            {
                entity.RetornarElMenor = false;
            }
            await _context.AppRecipes.AddAsync(entity);


        }

        public void Update(AppRecipes entity)
        {
            if (entity.RetornarElMayor == null)
            {
                entity.RetornarElMayor = false;
            }
            if (entity.RetornarElMenor == null)
            {
                entity.RetornarElMenor = false;
            }
            _context.AppRecipes.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppRecipes entity = await GetById(id);
            _context.AppRecipes.Remove(entity);

        }

        public decimal TotalCost(int productId)
        {

            var totaCostProduct = (from c in _context.AppRecipes
                                   where c.AppproductsId == productId && c.SumValue == true
                                   select c.TotalCost).Sum();

            return (decimal)totaCostProduct;
        }



        public async Task<string> getMedidas(int? idProduct)
        {
            string result = string.Empty;
            string code = "MEDIDABASICA";
            AppRecipes recipesBasica = await _context.AppRecipes.Where(x => x.AppproductsId == idProduct && x.Code == code).FirstOrDefaultAsync();
            code = "MEDIDAOPUESTA";
            AppRecipes recipesOpuesta = await _context.AppRecipes.Where(x => x.AppproductsId == idProduct && x.Code == code).FirstOrDefaultAsync();

            if (recipesBasica != null && recipesOpuesta != null)
            {


                result = recipesBasica.DescriptionSearch + " X " + recipesOpuesta.DescriptionSearch;
            }

            return result;
        }


    }
}
