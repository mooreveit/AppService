using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
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
    public class CompetidoresController : ControllerBase
    {
        private readonly ICompetidoresService _competidoresService;

        public CompetidoresController(ICompetidoresService competidoresService )
        {
            _competidoresService = competidoresService;
        }

        /// <summary>
        /// Retorna los datos de CompetidoresGetDto
        /// Filtros a aplicar CompetidoresQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar CompetidoresQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<CompetidoresGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByAllFilter(CompetidoresQueryFilter filters)
        {


            var response = await _competidoresService.GetByAllFilter(filters);
            return Ok(response);



        }





    }
}