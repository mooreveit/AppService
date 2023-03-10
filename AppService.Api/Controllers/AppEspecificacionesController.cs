using AppService.Api.Responses;
using AppService.Core.DTOs.Especificaciones;
using AppService.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppEspecificacionesController : ControllerBase
    {

        private readonly IAppEspecificacionesServices _appEspecificacionesServices;


        public AppEspecificacionesController(IAppEspecificacionesServices appEspecificacionesServices)
        {

            _appEspecificacionesServices = appEspecificacionesServices;

        }


        /// <summary>
        /// Crea y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filter">Filtros a aplicar PartesFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<PartesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllFilter(PartesFilter filter)
        {


            var result = await _appEspecificacionesServices.GetAllFilter(filter);
            return Ok(result);


        }
        /// <summary>
        /// Crea y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="dto">Filtros a aplicar PartesFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<PartesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateEspecificaciones(EspecificacionesUpdateDto dto)
        {


            var result = await _appEspecificacionesServices.UpdateEspecificaciones(dto);
            return Ok(result);


        }



    }
}
