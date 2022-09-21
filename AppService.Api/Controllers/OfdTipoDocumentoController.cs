using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;


namespace AppService.Api.Controllers
{

    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OfdTipoDocumentoController : ControllerBase
    {


        private readonly IOfdTipoDocumentoService _ofdTipoDocumentoService;

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        public OfdTipoDocumentoController(IOfdTipoDocumentoService ofdTipoDocumentoService, IMapper mapper, IUriService uriService)
        {
            _ofdTipoDocumentoService = ofdTipoDocumentoService;
            _mapper = mapper;
            _uriService = uriService;
        }



        /// <summary>
        /// Retorna listas de tipos de documento
        /// </summary>
        /// <param name="filters">Filtros a aplicar</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<OfdTipoDocumentoDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetAll([FromQuery] OfdTipoDocumentoQueryFilter filters)
        {


            IEnumerable<OfdTipoDocumento> ofdTipoDocumento = _ofdTipoDocumentoService.GetAll(filters);

            IEnumerable<OfdTipoDocumentoDto> ofdTipoDocumentoDto = _mapper.Map<IEnumerable<OfdTipoDocumentoDto>>(ofdTipoDocumento);





            //ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzasDtos);
            var response = new ApiResponse<IEnumerable<OfdTipoDocumentoDto>>(ofdTipoDocumentoDto)
            {
                Meta = null
            };



            return Ok(response);

        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult GetAllTipoDocumento(OfdTipoDocumentoQueryFilter filters)
        {


            IEnumerable<OfdTipoDocumento> ofdTipoDocumento = _ofdTipoDocumentoService.GetAll(filters);

            IEnumerable<OfdTipoDocumentoDto> ofdTipoDocumentoDto = _mapper.Map<IEnumerable<OfdTipoDocumentoDto>>(ofdTipoDocumento);


            var response = new ApiResponse<IEnumerable<OfdTipoDocumentoDto>>(ofdTipoDocumentoDto)
            {
                Meta = null
            };



            return Ok(response);

        }





    }
}