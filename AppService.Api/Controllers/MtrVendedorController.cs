using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
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
    public class MtrVendedorController : ControllerBase
    {

        private readonly IMtrVendedorService _mtrVendedorService;
        private readonly IMapper _mapper;

        public MtrVendedorController(IMtrVendedorService mtrVendedorService, IMapper mapper)
        {
            _mtrVendedorService = mtrVendedorService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> ListVendedoresPorUsuario(MtrVendedorQueryFilter filters)
        {


            IEnumerable<MtrVendedor> vendedores = await _mtrVendedorService.ListVendedoresPorUsuario(filters);

            IEnumerable<MtrVendedorDto> vendedoressDtos = _mapper.Map<IEnumerable<MtrVendedorDto>>(vendedores);



            ApiResponse<IEnumerable<MtrVendedorDto>> response = new ApiResponse<IEnumerable<MtrVendedorDto>>(vendedoressDtos);




            return Ok(response);
        }


    }
}