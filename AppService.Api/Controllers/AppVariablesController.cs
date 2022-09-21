using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.QueryFilters;
using AppService.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppVariablesController : ControllerBase
    {
        private readonly IAppVariablesService _appVariablesService;

        public AppVariablesController(IAppVariablesService appVariablesService)
        {
            _appVariablesService = appVariablesService;
        }



        /// <summary>
        /// Retorna los datos de AppVariablesGetDto
        /// Filtros a aplicar AppVariablesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariablesQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppVariablesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppVariable(AppVariablesQueryFilter filters)
        {
            

            var response = await _appVariablesService.GetAllFilter(filters);
            return Ok(response);



        }

        /// <summary>
        /// Crea una variabe,Retorna los datos de AppVariablesGetDto
        /// Filtros a aplicar AppVariablesCreateDto, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariablesCreateDto, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppVariablesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateVariables(AppVariablesCreateDto dto)
        {


            var response = await _appVariablesService.CreateVariables(dto);
            return Ok(response);



        }

        /// <summary>
        /// Actualiza una variabe,Retorna los datos de AppVariablesGetDto
        /// Filtros a aplicar AppVariablesCreateDto, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariablesCreateDto, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppVariablesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateVariables(AppVariablesUpdateDto dto)
        {


            var response = await _appVariablesService.UpdateVariables(dto);
            return Ok(response);



        }

        /// <summary>
        /// Elimina variabe,Retorna los datos de AppVariablesGetDto
        /// Filtros a aplicar AppVariablesCreateDto, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariablesCreateDto, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteVariables(AppVariablesDeleteDto dto)
        {


            var response = await _appVariablesService.DeleteVariables(dto);
            return Ok(response);



        }


    }
}