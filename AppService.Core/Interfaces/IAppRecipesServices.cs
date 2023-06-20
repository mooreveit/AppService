
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppRecipesServices
    {
        Task<List<AppRecipes>> GetRecipesByProductId(int productId);

        Task<List<AppRecipes>> GetAllRecipesByProductId(int productId);

        Task<AppRecipes> GetById(int id);

        Task<AppRecipes> Insert(AppRecipes appRecipes);

        Task<AppRecipes> Update(AppRecipes appRecipes);

        Task<bool> Delete(int id);

        Task<ApiResponse<bool>> DeleteAppRecipes(AppRecipesDeleteDto dto);

        Task<AppRecipes> GetRecipesByProductIdVariableId(int productId, int variableId);

        Task<Decimal> CalculateFormula(int recipe);

        Task<string> GetValueFormula(string formula, string codeProduct, string codeRecipe);

        Task<List<AppRecipesGetDto>> CalulateRecipeByProduct(int productId);

        Task UpdatePriceByProduct(int productId);

        Task<List<AppRecipesGetDto>> GetRecipesGetDtoByProductId(
          AppRecipesQueryFilter filter);

        Task UpdateIngredientsCostRecipeByProduct(int productId);

        Task<ApiResponse<List<AppRecipesGetDto>>> CreateAppRecipes(
          AppRecipesCreateDto dto);

        Task<ApiResponse<List<AppRecipesGetDto>>> UpdateAppRecipes(
          AppRecipesUpdateDto dto);

        Task<ApiResponse<List<AppRecipesGetDto>>> CopyRecipes(
          AppCopyRecipesDto appCopyRecipesDto);

        Task CalculateAllProduct();

        Task ValidateAllReceipProduct();

        Task CreaVariables();
    }
}
