using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MtrTipoMonedaController : ControllerBase
    {

        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        public MtrTipoMonedaController(IMtrTipoMonedaService mtrTipoMonedaService, IMapper mapper, IUriService uriService)
        {
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult GetAllTipoMoneda(MtrTipoMonedaQueryFilter filters)
        {


            IEnumerable<MtrTipoMoneda> tipoMonedas = _mtrTipoMonedaService.GetAll(filters);

            IEnumerable<MtrTipoMonedaDto> tipoMonedasDto = _mapper.Map<IEnumerable<MtrTipoMonedaDto>>(tipoMonedas);


            var response = new ApiResponse<IEnumerable<MtrTipoMonedaDto>>(tipoMonedasDto)
            {
                Meta = null
            };



            return Ok(response);

        }





    }
}