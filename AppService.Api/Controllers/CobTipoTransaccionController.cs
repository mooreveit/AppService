using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CobTipoTransaccionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICobTipoTransaccionService _cobTipoTransaccionService;

        public CobTipoTransaccionController(IMapper mapper,ICobTipoTransaccionService cobTipoTransaccionService)
        {
            _mapper = mapper;
            _cobTipoTransaccionService = cobTipoTransaccionService;
        }

        /// <summary>
        /// Retorna Lista de Tipo Transaccion
        /// </summary>
        /// <param name="filters">Filtros a aplicar</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobTipoTransaccionDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetCobTipoTransaccion()
        {


            IEnumerable<CobTipoTransaccion> tipoTransaccion =  _cobTipoTransaccionService.GetAll();

            IEnumerable<CobTipoTransaccionDto> tipoTransaccionDtos = _mapper.Map<IEnumerable<CobTipoTransaccionDto>>(tipoTransaccion);



            ApiResponse<IEnumerable<CobTipoTransaccionDto>> response = new ApiResponse<IEnumerable<CobTipoTransaccionDto>>(tipoTransaccionDtos);




            return Ok(response);

        }



        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetListCobTipoTransaccion()
        {


            IEnumerable<CobTipoTransaccion> tipoTransaccion = _cobTipoTransaccionService.GetAll();

            IEnumerable<CobTipoTransaccionDto> tipoTransaccionDtos = _mapper.Map<IEnumerable<CobTipoTransaccionDto>>(tipoTransaccion);



            ApiResponse<IEnumerable<CobTipoTransaccionDto>> response = new ApiResponse<IEnumerable<CobTipoTransaccionDto>>(tipoTransaccionDtos);




            return Ok(response);
        }
    }
}