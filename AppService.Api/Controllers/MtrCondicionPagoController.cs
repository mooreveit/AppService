using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MtrCondicionPagoController : ControllerBase
    {
        private readonly IMtrCondicionPagoService _mtrCondicionPagoService;

        public MtrCondicionPagoController(IMtrCondicionPagoService mtrCondicionPagoService)
        {
            _mtrCondicionPagoService = mtrCondicionPagoService;
        }


        /// <summary>
        /// Retorna los datos Condicion PAgo
        /// Filtros a aplicar NA, 
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<CondicionPagoDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAll(CondicionPagoQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var condiciones = await _mtrCondicionPagoService.GetAll();
                if (filters.Codigo>0)
                {
                    condiciones = condiciones.Where(x => x.Codigo == filters.Codigo).ToList();
                }

                if (condiciones != null)
                {
                    metadata.IsValid = true;
                    metadata.Message = "";
                   

                    ApiResponse<List<CondicionPagoDto>> response = new ApiResponse<List<CondicionPagoDto>>(condiciones)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = true;
                    metadata.Message = "No Nada.......";
                   

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(null)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }

    }
}