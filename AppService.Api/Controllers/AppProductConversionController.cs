// Decompiled with JetBrains decompiler
// Type: AppService.Api.Controllers.AppProductConversionController
// Assembly: AppService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A48E1D3D-4271-4A51-8AC5-EAB6CF82BD51
// Assembly location: D:\Moore\Publish\AppService.Api.dll
// XML documentation location: D:\Moore\Publish\AppService.Api.xml

using AppService.Core.DTOs;
using AppService.Core.Entities;
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
    public class AppProductConversionController : ControllerBase
    {
        private readonly IAppProductConversionService _appProductConversionService;

        public AppProductConversionController(
          IAppProductConversionService appProductConversionService)
        {
            this._appProductConversionService = appProductConversionService;
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<AppProductConversionGetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetByKey(AppProductConversionFilter filters)
        {
            AppProductConversionController conversionController = this;
            AppProductConversion byId = await conversionController._appProductConversionService.GetById(filters.Id.Value);
            return (IActionResult)conversionController.Ok((object)byId);
        }

        /// <summary>
        /// Crea un AppPrice y Retorna los datos de AppPriceGetDto
        /// Filtros a aplicar NA,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<AppProductConversionGetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateAppProductConversion(
          AppProductConversionCreateDto dto)
        {
            AppProductConversionController conversionController = this;
            Core.Responses.ApiResponse<AppProductConversionGetDto> apiResponse = await conversionController._appProductConversionService.InsertConversion(dto);
            return (IActionResult)conversionController.Ok((object)apiResponse);
        }

        /// <summary>
        /// Crea un AppPrice y Retorna los datos de AppPriceGetDto
        /// Filtros a aplicar NA,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<AppProductConversionGetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateAppProductConversion(
          AppProductConversionUpdateDto dto)
        {
            AppProductConversionController conversionController = this;
            Core.Responses.ApiResponse<AppProductConversionGetDto> apiResponse = await conversionController._appProductConversionService.UpdateConversion(dto);
            return (IActionResult)conversionController.Ok((object)apiResponse);
        }

        /// <summary>
        /// Elimina un AppPrice
        /// Filtros a aplicar NA,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<AppProductConversionGetDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> DeleteAppProductConversion(
          AppProductConversionFilter dto)
        {
            AppProductConversionController conversionController = this;
            Core.Responses.ApiResponse<AppProductConversionGetDto> apiResponse = await conversionController._appProductConversionService.DeletePrice(dto.Id.Value);
            return (IActionResult)conversionController.Ok((object)apiResponse);
        }

        /// <summary>
        /// Consulat AppPrice  por Producto
        /// Filtros a aplicar NA,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(Core.Responses.ApiResponse<List<AppProductConversionGetDto>>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllByAppProduct(AppProductConversionFilter filters) => (IActionResult)this.Ok((object)this._appProductConversionService.GetAllByProduct(filters));
    }
}
