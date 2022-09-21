using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppRecipesByAppDetailQuotesService
    {
        Task<List<AppRecipesByAppDetailQuotes>> GetListByCalculoId(
          int calculoId);

        Task<AppPriceGetDto> GetPrecioProductoCantidad(
          int productId,
          Decimal cantidad);

        Task<ApiResponse<AppPriceGetDto>> GetPrice(appRecipesByAppDetailQuotesQueryFilter filter);

        Task ValidaFormula(AppRecipes recipe);
    }
}
