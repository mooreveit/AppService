using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppRecipesRepository
    {
        Task<List<AppRecipes>> GetAll();

        Task<List<AppRecipes>> GetAllRecipesByProductId(int productId);

        Task<List<AppRecipes>> GetRecipesByProductId(int productId);

        Task<AppRecipes> GetRecipesByProductIdVariableId(int productId, int variableId);

        Task<AppRecipes> GetById(int id);

        Task Add(AppRecipes entity);

        void Update(AppRecipes entity);

        Task Delete(int id);

        Decimal TotalCost(int productId);

        Task<AppRecipes> GetRecipesByProductCodeVariableCode(
          string codeProduct,
          string code);

        Task<List<AppRecipes>> GetListRecipesByProductCodeVariableCode(
          string codeProduct,
          string code);

        Task<List<AppRecipes>> GetListRecipesByCodeInFormula(string code);

        Task<List<AppRecipes>> GetRecipesWithIngredientsByProductId(int productId);

        Task<AppRecipes> GetRecipesByVariableCode(string code);

        Task<AppRecipes> GetRecipesByIdIngredients(int id);

        Task<AppRecipes> GetRecipesByCodeInFormula(int appproductsId, string code);

        Task<List<AppRecipes>> GetListRecipesByProductIdVariableCode(
          int idProduct,
          string code);

        Task<List<AppRecipes>> GetListRecipesByIdIngredients(int id);

        Task<List<AppRecipes>> GetRecipesByCategoryId(int categoryId);

        Task<List<AppRecipes>> GetRecipesByCategoryIdIncludeInSearch(int categoryId);

        Task<bool> ProductoRecibeEntrada(int appProductId);

        Task<AppRecipes> GetRecipesByProductIdCode(int appproductsId, string code);

        Task<AppRecipes> GetOneRecipesByProductIdVariableCode(int idProduct, string code);
        Task<string> getMedidas(int? idProduct);
    }
}
