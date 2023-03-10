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
    public class AppDocumentosFiscalesController : ControllerBase
    {
        private readonly IAppDocumentosFiscalesService _service;

        public AppDocumentosFiscalesController(IAppDocumentosFiscalesService service)
        {
            _service = service;
        }



        /// <summary>
        /// Retorna los datos de AppConfigAppGetDto
        /// Filtros a aplicar AppConfigAppQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppConfigAppQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppConfigAppGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult ReadTextPdf()
        {
            var src = "/Users/freveron/Documents/Moore/Facturacion/enProceso/Factura_2200732866.pdf";
            
                 var response = _service.ReadLineByLineTextPdf(src);
            //var response = _service.ReadTextPdf(src);
            return Ok(response);



        }

       


      




    }
}