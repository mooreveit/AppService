using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace AppService.Api.Controllers
{

    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {


      

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly ISegUsuarioService _segUsuarioService;
        private readonly IMtrTipoTransaccionCuentaDestinoService _mtrTipoTransaccionCuentaDestinoService;

        public MenuController(IMapper mapper, IUriService uriService, ISegUsuarioService segUsuarioService)
        {
          
            _mapper = mapper;
            _uriService = uriService;
            _segUsuarioService = segUsuarioService;
        }




        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetMenu(PageMenuQueryFilter filter)
        {
            List<PageMenuDto> result = new List<PageMenuDto>();
            result = await _segUsuarioService.GetMenuDtoByRole(filter.Role);

            return Ok(result);

        }


    }
}