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
    public class AppConfigAppController : ControllerBase
    {
        private readonly IAppConfigAppService _appConfigAppService;

        public AppConfigAppController(IAppConfigAppService appConfigAppService)
        {
            _appConfigAppService = appConfigAppService;
        }



        /// <summary>
        /// Retorna los datos de AppConfigAppGetDto
        /// Filtros a aplicar AppConfigAppQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppConfigAppQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppConfigAppGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AppConfigAppGetAllFilter(AppConfigAppQueryFilter filters)
        {


            var response = await _appConfigAppService.GetAllFilter(filters);
            return Ok(response);



        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppConfigAppGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByKey(AppConfigAppQueryFilter filters)
        {


            var response = await _appConfigAppService.GetByKey(filters.Clave);
            return Ok(response);



        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppConfigAppGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetParametrosMaquina()
        {


            var response = await _appConfigAppService.getParametrosMaquina();
            return Ok(response);



        }



        /// <summary>
        /// Crea un AppConfig y Retorna los datos de AppConfigAppGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="dto">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppConfigAppGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateAppConfig(AppConfigAppCreateDto dto)
        {



            var response = await _appConfigAppService.CreateAppConfig(dto);
            return Ok(response);



        }

        /// <summary>
        /// Actualiza ingrediente y Retorna los datos de AppConfigAppGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppConfigAppGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateAppConfig(AppConfigAppUpdateDto dto)
        {



            var response = await _appConfigAppService.UpdateAppConfig(dto);
            return Ok(response);



        }


        /// <summary>
        /// Elimina AppConfig
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteAppConfig(AppConfigAppDeleteDto dto)
        {

            var response = await _appConfigAppService.DeleteAppConfig(dto);
            return Ok(response);

        }



    }
}