using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Microsoft.Extensions.Options;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CobPagosRetencionesController : ControllerBase
    {
        private readonly ICobPagosRetencionesService _cobPagosRetencionesService;
        private readonly ICobGrabacionCobranzasService _cobGrabacionCobranzasService;
        private readonly ICobTransaccionesService _cobTransaccionesService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly ICobValoresRetencionesService _cobValoresRetencionesService;
        private readonly ICobEstadoCuentaService _cobEstadoCuentaService;
        private readonly ITPaTasaBancoCentralServices _tPaTasaBancoCentralServices;
        private readonly PaginationOptions _paginationOptions;

        //Constructor
        public CobPagosRetencionesController(ICobPagosRetencionesService cobPagosRetencionesService,
                                            ICobGrabacionCobranzasService cobGrabacionCobranzasService,
                                            ICobTransaccionesService cobTransaccionesService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IOptions<PaginationOptions> options,
                                            IOfdTipoDocumentoService ofdTipoDocumentoService,
                                            ICobValoresRetencionesService cobValoresRetencionesService,
                                            ICobEstadoCuentaService cobEstadoCuentaService,
                                            ITPaTasaBancoCentralServices tPaTasaBancoCentralServices
                                            )
        {
            _cobPagosRetencionesService = cobPagosRetencionesService;
            _cobGrabacionCobranzasService = cobGrabacionCobranzasService;
            _cobTransaccionesService = cobTransaccionesService;
            _mapper = mapper;
            _uriService = uriService;
            _cobValoresRetencionesService = cobValoresRetencionesService;
            _cobEstadoCuentaService = cobEstadoCuentaService;
            _tPaTasaBancoCentralServices = tPaTasaBancoCentralServices;
            _paginationOptions = options.Value;
        }

        //
        /// <summary>
        /// Retorna los datos de Retenciones
        /// Filtros a aplicar CobPagoRetencionesFilter, si en el objeto incluye IdCobro, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AdjuntosCobranzaFilter, si en el objeto incluye documento, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobPagosRetencionesDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllCobPagosRetenciones(CobPagosRetencionesQueryFilter filters)
        {


            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };

            List <CobPagosRetenciones> listaCobPagosRetenciones = new List<CobPagosRetenciones>();
          
            try
            {
                listaCobPagosRetenciones = _cobPagosRetencionesService.GetListCobPagosRetenciones(filters).ToList();

                IEnumerable<CobPagosRetencionesDto> cobPagosRetencionesDtos = _mapper.Map<IEnumerable<CobPagosRetencionesDto>>(listaCobPagosRetenciones);


                if (cobPagosRetencionesDtos != null)
                {
                    foreach (var itemRet in cobPagosRetencionesDtos)
                    {
                        decimal decimalValue = (decimal)itemRet.Monto;
                        itemRet.MontoString = string.Format("{0:N}", decimalValue); // 1,234,567.00

                        CobTransacciones transaccion = await _cobTransaccionesService.GetById(itemRet.IdTransaccion);
                        if (transaccion != null)
                        {
                            itemRet.NombreTransaccion = transaccion.NombreTransaccion;
                            itemRet.TxOrigen = transaccion.TipoSap;
                        }
                        itemRet.FechaComprobanteString = itemRet.FechaComprobante.ToShortDateString();

                    }

                }

                PagedList<CobPagosRetencionesDto> pagedRetenciones = PagedList<CobPagosRetencionesDto>.Create(cobPagosRetencionesDtos, filters.PageNumber, filters.PageSize);


                metadata.IsValid = true;
                metadata.Message = "";


                var response = new ApiResponse<IEnumerable<CobPagosRetencionesDto>>(pagedRetenciones)
                {
                    Meta = metadata
                };

                return Ok(response);
            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message =ex.InnerException.Message;


                var response = new ApiResponse<List<CobPagosRetencionesDto>>(null)
                {
                    Meta = metadata
                };

                return Ok(response);
            }
          


        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Insert(CobPagosRetencionesDto cobPagosRetencionesDto)
        {
            CobPagosRetencionesDto resultDto = new CobPagosRetencionesDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
         
            CobPagosRetenciones cobPagosRetenciones = _mapper.Map<CobPagosRetenciones>(cobPagosRetencionesDto);

            var retencionValida = await _cobPagosRetencionesService.ValidateInsert(cobPagosRetenciones);

            if (!retencionValida.IsValid)
            {
                metadata = retencionValida;
            }
            else
            {


                //AGREGAMOS EL REGISTRO
                cobPagosRetenciones.FechaCrea = DateTime.Now;

                cobPagosRetenciones.FlagComprobanteNo = false;

                var grabacionCobranza = await _cobGrabacionCobranzasService.GetById(cobPagosRetenciones.IdCobranza);

                var estadoCuenta = await _cobEstadoCuentaService.GetEstadoCuentaById(grabacionCobranza.DocAfecta);

                var ValRet = await _cobValoresRetencionesService.GetById(cobPagosRetenciones.IdTransaccion);

                //Se determina si la retencion es por la base o por el iva de la factura
                decimal  baseCalculoRetencion = 0;
                if (ValRet.FlagRetieneSobreImp != true)
                {
                    baseCalculoRetencion = (decimal)estadoCuenta.BaseImponible;
                   
                }
                else
                {
                    baseCalculoRetencion = (decimal)(estadoCuenta.Iva);
                  
                }

                if (estadoCuenta.Moneda=="USD")
                {

                    var tasa = await _tPaTasaBancoCentralServices.GetTasaByFecha((DateTime)estadoCuenta.FechaDocumento);
                    if (tasa!= null)
                    {
                        baseCalculoRetencion = baseCalculoRetencion * (decimal)tasa.Tasa;
                    }
                    else
                    {
                        var ultimaTasa = await _tPaTasaBancoCentralServices.GetTasaByFecha((DateTime)DateTime.Now);
                        baseCalculoRetencion = baseCalculoRetencion * (decimal)ultimaTasa.Tasa;
                    }
                  


                }
                cobPagosRetenciones.Monto = Math.Round((cobPagosRetenciones.Porcentaje / Convert.ToDecimal(100.0000)) * Convert.ToDecimal(baseCalculoRetencion), 2);

                var transaccion = await _cobTransaccionesService.GetById(cobPagosRetencionesDto.IdTransaccion);
                decimal Diferencia = 0;

                Diferencia = Math.Abs(cobPagosRetenciones.Monto - cobPagosRetencionesDto.Monto);
                if (Diferencia <= transaccion.BsHolgura)
                {
                    cobPagosRetenciones.Monto = cobPagosRetencionesDto.Monto;
                }


                var cobranza = await _cobPagosRetencionesService.Insert(cobPagosRetenciones);
                if (cobranza != null)
                {
                    if (grabacionCobranza.Transaccion=="RE")
                    {
                        
                        grabacionCobranza.Monto = _cobPagosRetencionesService.GetTotalRetencionesByIdCobranzas(grabacionCobranza.Id); ;
                        var grabacionCobranzaResult = await _cobGrabacionCobranzasService.Update(grabacionCobranza);
                    
                    }

                    resultDto = _mapper.Map<CobPagosRetencionesDto>(cobranza);
                    metadata.IsValid = true;
                    metadata.Message = "Creado Satisfactoriamente";
                }
                else
                {
                    metadata.IsValid = false;

                    metadata.Message = "Registro No actualizado";
                }
            }

            



            ApiResponse<CobPagosRetencionesDto> response = new ApiResponse<CobPagosRetencionesDto>(resultDto)
            {
                Meta = metadata,
            };
            return Ok(response);

        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Update(CobPagosRetencionesDto cobPagosRetencionesDto)
        {
            CobPagosRetencionesDto resultDto = new CobPagosRetencionesDto();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };


            CobPagosRetenciones cobPagosRetenciones = _mapper.Map<CobPagosRetenciones>(cobPagosRetencionesDto);

         
           
            var cobro = await _cobPagosRetencionesService.GetById(cobPagosRetencionesDto.Id);
            if (cobro!=null)
            {
                var retencionValida = await _cobPagosRetencionesService.ValidateInsert(cobPagosRetenciones);

                if (!retencionValida.IsValid && retencionValida.Message!= "Ya tiene porentaje cargado para este impuesto, eliminelo y vuelvalo a crear.")
                {
                    metadata = retencionValida;
                }
                else
                {
                    await Delete(cobPagosRetencionesDto);
                    cobPagosRetencionesDto.Id = 0;
                    await Insert(cobPagosRetencionesDto);
                    metadata.IsValid = true;

                    metadata.Message = "Retencion Actualizada";

                }


              

              
            }
            else
            {
                metadata.IsValid = false;

                metadata.Message = "Retencion No existe";
            }

           



            ApiResponse<CobPagosRetencionesDto> response = new ApiResponse<CobPagosRetencionesDto>(resultDto)
            {
                Meta = metadata,
            };
            return Ok(response);

        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Delete(CobPagosRetencionesDto cobPagosRetencionesDto)
        {
            CobPagosRetencionesDto resultDto = new CobPagosRetencionesDto();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            CobPagosRetenciones cobPagosRetenciones = _mapper.Map<CobPagosRetenciones>(cobPagosRetencionesDto);
        


            var cobranza = await _cobPagosRetencionesService.Delete(cobPagosRetencionesDto.Id);
            if (cobranza)
            {

                var grabacionCobranza = await _cobGrabacionCobranzasService.GetById(cobPagosRetenciones.IdCobranza);
                if (grabacionCobranza.Transaccion == "RE")
                {
                    grabacionCobranza.Monto = grabacionCobranza.Monto - cobPagosRetenciones.Monto;
                    var grabacionCobranzaResult = await _cobGrabacionCobranzasService.Update(grabacionCobranza);
                }

                metadata.IsValid = true;
                metadata.Message = "Registro eliminado Satisfactoriamente";
            }
            else
            {
                metadata.IsValid = false;

                metadata.Message = "Registro No Eliminado";
            }



            ApiResponse<CobPagosRetencionesDto> response = new ApiResponse<CobPagosRetencionesDto>(resultDto)
            {
                Meta = metadata,
            };
            return Ok(response);

        }

    }
}