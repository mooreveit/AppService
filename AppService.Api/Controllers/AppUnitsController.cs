using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppUnitsController : ControllerBase
    {
        private readonly IAppUnitsService _appUnitsService;

        public AppUnitsController(IAppUnitsService appUnitsService )
        {
            _appUnitsService = appUnitsService;
        }


        /// <summary>
        /// Retorna los datos de AppUnitsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppUnitsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppUnits(AppUnitsQueryFilter filters)
        {

          

               var response = await _appUnitsService.GetAll(filters);
                return Ok(response);
           


        }

        /// <summary>
        /// Retorna los datos de AppUnitsGetDto
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppUnitsQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppUnitsGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAppUnitsWithConversion(AppUnitsQueryFilter filters)
        {



            var response = await _appUnitsService.GetAppUnitsWithConversion(filters);
            return Ok(response);



        }



    }
}