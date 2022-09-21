using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OfdCotizacionController : ControllerBase
    {
        private readonly IOfdCotizacionService _ofdCotizacionService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly PaginationOptions _paginationOptions;

        //Constructor
        public OfdCotizacionController(IOfdCotizacionService ofdCotizacionService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IOptions<PaginationOptions> options,
                                            IOfdTipoDocumentoService ofdTipoDocumentoService,
                                            IMtrClienteService mtrClienteService)
        {


            _ofdCotizacionService = ofdCotizacionService;
            _mapper = mapper;
            _uriService = uriService;
            _mtrClienteService = mtrClienteService;
            _paginationOptions = options.Value;
        }




        //
        /// <summary>
        /// Retorna los datos del la cotizacion y valida si pertenece a un cliete
        /// Filtros a aplicar OfdCotizacionQueryFilter, si en el objeto incluye IdCliente, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar OfdCotizacionQueryFilter, si en el objeto incluye IdCliente, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<OfdCotizacionDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<IActionResult> ValidarCotizacionCliente(OfdCotizacionQueryFilter filters)
        {


            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
            };


            OfdCotizacion cotizacion = new OfdCotizacion();
            OfdCotizacionDto cotizacionDto = new OfdCotizacionDto();

            cotizacion = await _ofdCotizacionService.GetCotizacion(filters.Cotizacion);

            if (cotizacion != null)
            {
                if (cotizacion.IdCliente == filters.IdCliente)
                {
                    metadata.IsValid = true;
                    metadata.Message = "";
                    cotizacionDto = _mapper.Map<OfdCotizacionDto>(cotizacion);
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Cotizacion no pertenece a este cliente!!! " + filters.IdCliente;
                }

            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Cotizacion no existe!!!";
            }


            ApiResponse<OfdCotizacionDto> response = new ApiResponse<OfdCotizacionDto>(cotizacionDto)
            {
                Meta = metadata
            };


            return Ok(response);
        }


    }
}