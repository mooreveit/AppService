using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppPriceController : ControllerBase
    {

        private readonly IAppPriceServices _appPriceServices;

        public AppPriceController(IAppPriceServices appPriceServices)
        {
            _appPriceServices = appPriceServices;
        }

        /// <summary>
        /// Busca receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppPriceGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllPriceByProductId(AppPriceQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var recipes = await _appPriceServices.GetAllByAppProduct(filters.AppProductsId);
                return Ok(recipes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppPriceGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        /// <summary>
        /// Crea un AppPrice y Retorna los datos de AppPriceGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppPriceGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateAppPrice(AppPriceCreateDto dto)
        {

            var response = await _appPriceServices.InsertPrice(dto);
            return Ok(response);


        }


        /// <summary>
        /// Actualiza un AppPrice y Retorna los datos de AppPriceGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppPriceGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateAppPrice(AppPriceUpdateDto dto)
        {

            var response = await _appPriceServices.UpdatePrice(dto);
            return Ok(response);


        }



        /// <summary>
        /// Elimina un AppPrice y Retorna los datos de AppPriceGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppPriceGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeletePrice(AppPriceDeleteDto dto)
        {

            var response = await _appPriceServices.DeletePrice(dto.Id);
            return Ok(response);


        }
    }
}
