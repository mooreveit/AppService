using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
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
    public class MtrOficinaController : ControllerBase
    {


        private readonly IMtrOficinaService _mtrOficinaService;

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        public MtrOficinaController(IMtrOficinaService mtrOficinaService, IMapper mapper, IUriService uriService)
        {
            _mtrOficinaService = mtrOficinaService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetAllOficinas(MtrOficinaQueryFilter filters)
        {


            PagedList<MtrOficina> oficinas = await _mtrOficinaService.ListOficinasPorUsuario(filters);

            IEnumerable<MtrOficinaDto> oficinasDtos = _mapper.Map<IEnumerable<MtrOficinaDto>>(oficinas);



            Metadata metadata = new Metadata
            {
                TotalCount = oficinas.TotalCount,
                PageSize = oficinas.PageSize,
                CurrentPage = oficinas.CurrentPage,
                TotalPage = oficinas.TotalPage,
                HasNextPage = oficinas.HasNextPage,
                HasPreviousPage = oficinas.HasPreviousPage,
                NextPageUrl ="",
                PreviousPageUrl = "",
            };

            var response = new ApiResponse<IEnumerable<MtrOficinaDto>>(oficinasDtos)
            {
                Meta = metadata
            };

          

            return Ok(response);

        }


    }
}