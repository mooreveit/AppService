using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    [Produces("application/json", new string[] { })]
    [Route("api/[controller]")]
    [ApiController]
    public class AppProductsController : ControllerBase
    {
        private readonly IAppProductsService _appProductsService;
        private readonly IAppRecipesServices _appRecipesServices;
        private readonly IAppProductConversionService _appProductConversionService;

        public AppProductsController(
          IAppProductsService appProductsService,
          IAppRecipesServices appRecipesServices,
          IAppProductConversionService appProductConversionService)
        {
            _appProductsService = appProductsService;
            _appRecipesServices = appRecipesServices;
            _appProductConversionService = appProductConversionService;
        }

        /// <summary>
        /// Retorna los datos de AppProductsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllAppProducts(
          AppProdutsQueryFilter filters)
        {
            AppProductsController productsController = this;
            Core.Responses.ApiResponse<List<AppProductsGetDto>> all = await productsController._appProductsService.GetAll(filters);
            return (IActionResult)productsController.Ok((object)all);
        }

        /// <summary>
        /// Retorna los datos de AppProductsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllAppProductsByVariable(
          AppVariableSearchCompareQueryFilterBySubCategory filter)
        {
            //AppProductsController productsController = this;
            Core.Responses.ApiResponse<List<AppProductsGetDto>> allByVariable = await _appProductsService.GetAllByVariable(filter.filters, filter.SubCategoryId);

            return Ok(allByVariable);

            //return (IActionResult)productsController.Ok((object)allByVariable);

        }

        /// <summary>
        /// Se crea registro de AppProducts
        /// ,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> InsertAppProducts(
          AppProductsCreateDto appProductsCreateDto)
        {
            AppProductsController productsController = this;
            Core.Responses.ApiResponse<AppProductsGetDto> apiResponse = await productsController._appProductsService.InsertProducts(appProductsCreateDto);
            return (IActionResult)productsController.Ok((object)apiResponse);
        }

        /// <summary>
        /// Actualiza de AppProducts
        /// ,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<List<AppProductsGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateAppProducts(
          AppProductsUpdateDto appProductsUpdateDto)
        {
            AppProductsController productsController = this;
            Core.Responses.ApiResponse<AppProductsGetDto> apiResponse = await productsController._appProductsService.UpdateProducts(appProductsUpdateDto);
            return (IActionResult)productsController.Ok((object)apiResponse);
        }



        /// <summary>
        /// Actualiza de AppProducts
        /// ,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateAppProductsToodoo()
        {
            await _appProductsService.SendAllToOdoo();
            return Ok();
        }

        /// <summary>
        /// Elimina Prorducto
        /// Filtros a aplicar AppVariablesCreateDto,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<bool>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> DeleteProduct(AppProductsDeleteDto dto)
        {
            AppProductsController productsController = this;
            Core.Responses.ApiResponse<bool> apiResponse = await productsController._appProductsService.DeleteProduct(dto);
            return (IActionResult)productsController.Ok((object)apiResponse);
        }

        /// <summary>
        /// Copia Prorducto
        /// Filtros a aplicar AppVariablesCreateDto,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<AppProductsGetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CopyProduct(AppProductsDeleteDto dto)
        {
            AppProductsController productsController = this;
            Core.Responses.ApiResponse<List<AppProductsGetDto>> response = new Core.Responses.ApiResponse<List<AppProductsGetDto>>(null);
            Core.Responses.ApiResponse<AppProductsGetDto> newProduct = await productsController._appProductsService.CopyProduct(dto.Id);
            if (await productsController._appProductsService.GetById(newProduct.Data.Id) != null)
            {
                Core.Responses.ApiResponse<List<AppRecipesGetDto>> apiResponse = await productsController._appRecipesServices.CopyRecipes(new AppCopyRecipesDto()
                {
                    productIdSince = (int)dto.Id,
                    productIdUntil = newProduct.Data.Id
                });

                await _appProductConversionService.CopyConversion(new AppCopyRecipesDto()
                {
                    productIdSince = (int)dto.Id,
                    productIdUntil = newProduct.Data.Id
                });

                AppProdutsQueryFilter filters = new AppProdutsQueryFilter();
                response = await _appProductsService.GetAll(filters);


            }

            IActionResult actionResult = (IActionResult)productsController.Ok((object)response);
            response = (Core.Responses.ApiResponse<List<AppProductsGetDto>>)null;
            return actionResult;
        }
    }
}
