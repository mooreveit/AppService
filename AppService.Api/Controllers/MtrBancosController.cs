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
    public class MtrBancosController : ControllerBase
    {


        private readonly IMtrBancosService _mtrBancosService;

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IMtrTipoTransaccionCuentaDestinoService _mtrTipoTransaccionCuentaDestinoService;

        public MtrBancosController(IMtrBancosService mtrBancosService , IMapper mapper, IUriService uriService,IMtrTipoTransaccionCuentaDestinoService mtrTipoTransaccionCuentaDestinoService)
        {
            _mtrBancosService = mtrBancosService;
            _mapper = mapper;
            _uriService = uriService;
            _mtrTipoTransaccionCuentaDestinoService = mtrTipoTransaccionCuentaDestinoService;
        }



        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetBancos(MtrBancosQueryFilter filters)
        {


            IEnumerable<MtrBancosDto> bancos =  await _mtrBancosService.GetAllFilter(filters);

            //IEnumerable<MtrBancosDto> bancosDto = _mapper.Map<IEnumerable<MtrBancosDto>>(bancos);


            //List<MtrBancosDto> result = new List<MtrBancosDto>();
            //var tipoTransaccionCuentaDestino = _mtrTipoTransaccionCuentaDestinoService.GetAll().ToList();

            //foreach (var itemtipo in tipoTransaccionCuentaDestino)
            //{
            //    var ban = bancosDto.Where(x => x.IdTipoCuentaDestino == itemtipo.IdTipoCuentaDestino ).ToList();

            //    foreach (var item in ban)
            //    {
            //         MtrBancosDto itemresult = new MtrBancosDto();
            //        itemresult = item;
            //        itemresult.IdTipoTransaccion = itemtipo.IdTipoTransaccion;
            //        result.Add(itemresult);
                 
                   
            //    }

            //}



            var response = new ApiResponse<IEnumerable<MtrBancosDto>>(bancos)
            {
                Meta = null
            };



            return Ok(response);

        }


    }
}