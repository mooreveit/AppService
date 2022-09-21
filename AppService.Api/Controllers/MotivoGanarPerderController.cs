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
    public class MotivoGanarPerderController : ControllerBase
    {


       
        private readonly IMotivoGanarPerderService _motivoGanarPerderService;

        public MotivoGanarPerderController(IMotivoGanarPerderService motivoGanarPerderService )
        {
            
            _motivoGanarPerderService = motivoGanarPerderService;
        }


        /// <summary>
        /// Retorna los datos de MotivoGanarPerderGetDto
        /// Filtros a aplicar MotivoGanarPerderQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar MotivoGanarPerderQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<MotivoGanarPerderGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> MotivoGanarPerderGetAllFilter(MotivoGanarPerderQueryFilter filters)
        {


            var response = await _motivoGanarPerderService.GetByCondicion(filters);
            return Ok(response);



        }




    }
}