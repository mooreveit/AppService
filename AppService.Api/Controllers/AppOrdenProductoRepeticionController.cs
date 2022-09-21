using AppService.Api.Responses;
using AppService.Core.DTOs.Repeticiones;
using AppService.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppOrdenProductoRepeticionController : ControllerBase
    {
        private readonly IAppOrdenProductoRepeticionServices _appOrdenProductoRepeticionServices;

        public AppOrdenProductoRepeticionController(IAppOrdenProductoRepeticionServices appOrdenProductoRepeticionServices)
        {
            _appOrdenProductoRepeticionServices = appOrdenProductoRepeticionServices;
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
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<ListaRepeticiones>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllFilter(AppOrdenProductoRepeticionFilterDto filter)
        {


            var response = await _appOrdenProductoRepeticionServices.GetAllFilter(filter);
            return Ok(response);



        }







    }
}