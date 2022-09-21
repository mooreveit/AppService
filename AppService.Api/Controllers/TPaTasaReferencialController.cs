using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TPaTasaReferencialController : ControllerBase
    {
        private readonly ITPaTasaReferencialServices _tPaTasaReferencialServices;
        private readonly IMapper _mapper;

        public TPaTasaReferencialController(ITPaTasaReferencialServices tPaTasaReferencialServices,
                                            IMapper mapper)
        {
            _tPaTasaReferencialServices = tPaTasaReferencialServices;
            _mapper = mapper;
        }


        /// <summary>
        /// Crea y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<TPaTasaReferencialGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetTasaReferecial(TasaPreferencialQueryFilter tasaPreferencialQueryFilter)
        {

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var tasa =await  _tPaTasaReferencialServices.GetTasaByFecha(tasaPreferencialQueryFilter.FechaTasa);

                TPaTasaReferencialGetDto tasaDto = _mapper.Map<TPaTasaReferencialGetDto>(tasa);

                ApiResponse<TPaTasaReferencialGetDto> response = new ApiResponse<TPaTasaReferencialGetDto>(tasaDto);
                response.Meta = metadata;
                return Ok(response);





            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<TPaTasaReferencialGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }



    }
}