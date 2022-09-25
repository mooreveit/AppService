using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppIngredientsController : ControllerBase
    {
        private readonly IAppIngredientsService _appIngredientsService;

        public AppIngredientsController(IAppIngredientsService appIngredientsService)
        {
            _appIngredientsService = appIngredientsService;
        }



        /// <summary>
        /// Retorna los datos de AppIngredientsGetDto
        /// Filtros a aplicar AppIngredientsQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppIngredientsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppIngredientsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppIngredients(AppIngredientsQueryFilter filters)
        {



            var response = await _appIngredientsService.GetAllFilter(filters);
            return Ok(response);



        }

        /// <summary>
        /// Crea un ingrediente y Retorna los datos de AppIngredientsGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppIngredientsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateAppIngredient(AppIngredientsCreateDto dto)
        {



            var response = await _appIngredientsService.CreateAppIngredient(dto);
            return Ok(response);



        }

        /// <summary>
        /// Actualiza ingrediente y Retorna los datos de AppIngredientsGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppIngredientsGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateAppIngredient(AppIngredientsUpdateDto dto)
        {



            var response = await _appIngredientsService.UpdateAppIngredient(dto);
            return Ok(response);



        }


        /// <summary>
        /// Actualiza ingrediente y Retorna los datos de AppIngredientsGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeteAppIngredient(AppIngredientsDeleteDto dto)
        {

            var response = await _appIngredientsService.DeleteAppIngredients(dto);
            return Ok(response);

        }




    }
}