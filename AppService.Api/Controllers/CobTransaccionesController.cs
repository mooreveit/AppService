using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CobTransaccionesController : ControllerBase
    {


        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly ICobTransaccionesService _cobTransaccionesService;

        public CobTransaccionesController( IMapper mapper, IUriService uriService, ICobTransaccionesService cobTransaccionesService)
        {
           
            _mapper = mapper;
            _uriService = uriService;
            _cobTransaccionesService = cobTransaccionesService;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetTransaccionesEfectivo()
        {


            List<CobTransacciones> transacciones =  _cobTransaccionesService.GetAll();

            List<CobTransaccionesDto> transaccionesDto = _mapper.Map<List<CobTransaccionesDto>>(transacciones);


           



            var response = new ApiResponse<List<CobTransaccionesDto>>(transaccionesDto)
            {
                Meta = null
            };



            return Ok(response);

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetTransaccionesRetenciones()
        {


            List<CobTransacciones> transacciones = _cobTransaccionesService.GetAllImpuesto();

            List<CobTransaccionesDto> transaccionesDto = _mapper.Map<List<CobTransaccionesDto>>(transacciones);


            var response = new ApiResponse<List<CobTransaccionesDto>>(transaccionesDto)
            {
                Meta = null
            };



            return Ok(response);

        }
       
        
        [HttpPost]
        [Route("[action]")]
        public IActionResult GetTransaccionesRetencionesById(CobTransccionesQueryFilter cobTransccionesQueryFilter)
        {

            int id = cobTransccionesQueryFilter.IdTransacccionCobranzas;
            List<CobTransacciones> transacciones = _cobTransaccionesService.GetAllImpuesto();

            List<CobTransaccionesDto> transaccionesDto = _mapper.Map<List<CobTransaccionesDto>>(transacciones);

            var itemtransaccionesDto = transaccionesDto.Where(x => x.IdTransacccionCobranzas == id).FirstOrDefault();
            var response = new ApiResponse<CobTransaccionesDto>(itemtransaccionesDto)
            {
                Meta = null
            };



            return Ok(response);

        }

    }
}