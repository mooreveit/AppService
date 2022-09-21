using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json", new string[] { })]
    [Route("api/[controller]")]
    [ApiController]
    public class AppRecipesByAppDetailQuotesController : ControllerBase
    {
        private readonly IAppRecipesByAppDetailQuotesService _appRecipesByAppDetailQuotesService;

        public AppRecipesByAppDetailQuotesController(
          IAppRecipesByAppDetailQuotesService appRecipesByAppDetailQuotesService)
        {
            this._appRecipesByAppDetailQuotesService = appRecipesByAppDetailQuotesService;
        }

        /// <summary>
        /// Calcula receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(ApiResponse<AppCaluloPrecioDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetPrecioProductoCantidad(
          appRecipesByAppDetailQuotesQueryFilter filters)
        {
            AppRecipesByAppDetailQuotesController quotesController = this;
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(new AppPriceGetDto());
            Metadata metadata = new Metadata()
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };
            try
            {
                AppPriceGetDto productoCantidad = await quotesController._appRecipesByAppDetailQuotesService.GetPrecioProductoCantidad(filters.AppProuctId, (Decimal)filters.Cantidad);
                metadata.IsValid = true;
                metadata.Message = "";
                response.Data = productoCantidad;
                response.Meta = metadata;
                return (IActionResult)quotesController.Ok((object)productoCantidad);
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                ApiResponse<AppCaluloPrecioDto> apiResponse = new ApiResponse<AppCaluloPrecioDto>((AppCaluloPrecioDto)null)
                {
                    Meta = metadata
                };
                return (IActionResult)quotesController.Ok((object)apiResponse);
            }
        }


        /// <summary>
        /// Calcula receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(ApiResponse<AppCaluloPrecioDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetPrice(
          appRecipesByAppDetailQuotesQueryFilter filters)
        {
            AppRecipesByAppDetailQuotesController quotesController = this;
            ApiResponse<AppPriceGetDto> response = new ApiResponse<AppPriceGetDto>(new AppPriceGetDto());
            Metadata metadata = new Metadata()
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };
            try
            {
                var productoCantidad = await _appRecipesByAppDetailQuotesService.GetPrice(filters);

                return (IActionResult)quotesController.Ok((object)productoCantidad);
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                ApiResponse<AppCaluloPrecioDto> apiResponse = new ApiResponse<AppCaluloPrecioDto>((AppCaluloPrecioDto)null)
                {
                    Meta = metadata
                };
                return (IActionResult)quotesController.Ok((object)apiResponse);
            }
        }


    }
}
