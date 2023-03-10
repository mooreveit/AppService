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
    public class OdooController : ControllerBase
    {

        private readonly ICotizacionService _cotizacionService;

        public OdooController(ICotizacionService cotizacionService)
        {
            _cotizacionService = cotizacionService;
        }

        protected async Task ExecuteAsync()
        {


            await _cotizacionService.ActualizarClientes();

            await _cotizacionService.UpdateCotizacionesToOdoo();



        }








        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppConfigAppGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetParametrosMaquina()
        {

            await ExecuteAsync();
            var response = true;
            return Ok(response);



        }










    }
}