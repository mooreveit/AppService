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
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CobGrabacionCobranzasController : ControllerBase
    {
        private readonly ICobGrabacionCobranzasService _cobGrabacionCobranzasService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly ICobEstadoCuentaService _cobEstadoCuentaService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly IGeneralCobranzaService _generalCobranzaService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;
        private readonly ICobMatrixMonedaValidaPagoService _cobMatrixMonedaValidaPagoService;
        private readonly IOfdCotizacionService _ofdCotizacionService;
        private readonly PaginationOptions _paginationOptions;

        //Constructor
        public CobGrabacionCobranzasController(ICobGrabacionCobranzasService cobGrabacionCobranzasService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IOptions<PaginationOptions> options,
                                            IOfdTipoDocumentoService ofdTipoDocumentoService,
                                            ICobEstadoCuentaService cobEstadoCuentaService,
                                            IMtrClienteService mtrClienteService,
                                            IGeneralCobranzaService generalCobranzaService,
                                            IMtrTipoMonedaService mtrTipoMonedaService,
                                            ICobMatrixMonedaValidaPagoService cobMatrixMonedaValidaPagoService,
                                            IOfdCotizacionService ofdCotizacionService)
        {

            _cobGrabacionCobranzasService = cobGrabacionCobranzasService;
            _mapper = mapper;
            _uriService = uriService;
            _cobEstadoCuentaService = cobEstadoCuentaService;
            _mtrClienteService = mtrClienteService;
            _generalCobranzaService = generalCobranzaService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _cobMatrixMonedaValidaPagoService = cobMatrixMonedaValidaPagoService;
            _ofdCotizacionService = ofdCotizacionService;
            _paginationOptions = options.Value;
        }

        //
        /// <summary>
        /// Retorna los datos de Grabacio cobranza
        /// Filtros a aplicar AdjuntosCobranzaFilter, si en el objeto incluye documento, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AdjuntosCobranzaFilter, si en el objeto incluye documento, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobGrabacionCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<IActionResult> GetAllGrabacionCobranza(CobGrabacionCobranzasQueryFilter filters)
        {


            PagedList<CobGrabacionCobranzas> listaCobGrabacionCobranzas;

            listaCobGrabacionCobranzas = _cobGrabacionCobranzasService.GetCobGrabacionCobranzas(filters);

            IEnumerable<CobGrabacionCobranzaDto> listaCobGrabacionCobranzasDto = _mapper.Map<IEnumerable<CobGrabacionCobranzaDto>>(listaCobGrabacionCobranzas);

            foreach (CobGrabacionCobranzaDto item in listaCobGrabacionCobranzasDto)
            {

                if (item.Transaccion == "RU")
                {
                    item.DocAfectaMostrar = item.Cotizacion;
                }
                else
                {
                    item.DocAfectaMostrar = item.DocAfectaSap;

                }

                decimal decimalValue = (decimal)item.Monto;
                item.MontoMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00

                CobEstadoDeCuenta cobEstadoDeCuenta = await _cobEstadoCuentaService.GetEstadoCuentaById(item.DocAfecta);

                if (cobEstadoDeCuenta != null)
                {
                    decimalValue = (decimal)cobEstadoDeCuenta.BaseImponible;
                    item.BaseImponible = (decimal)cobEstadoDeCuenta.BaseImponible;
                    item.BaseImponibleMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    decimalValue = (decimal)cobEstadoDeCuenta.Iva;
                    item.Iva = (decimal)cobEstadoDeCuenta.Iva;
                    item.IvaMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    decimalValue = (decimal)cobEstadoDeCuenta.MontoOriginal;

                    item.MontoOriginalMostrar = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    item.FechaDocumento = cobEstadoDeCuenta.FechaDocumento;
                    DateTime fechaDocumento = (DateTime)cobEstadoDeCuenta.FechaDocumento;
                    item.FechaDocumentoString = fechaDocumento.ToShortDateString();

                    CobEstadoCuentaDto estadoCuentaDto = _mapper.Map<CobEstadoCuentaDto>(cobEstadoDeCuenta);

                    MtrCliente cliente = await _mtrClienteService.GetByIdAsync(estadoCuentaDto.IdCliente);



                    estadoCuentaDto.Saldo = estadoCuentaDto.Rpaap;
                    decimalValue = (decimal)estadoCuentaDto.Saldo;
                    estadoCuentaDto.SaldoString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    decimalValue = (decimal)estadoCuentaDto.Iva;
                    estadoCuentaDto.IvaString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    decimalValue = (decimal)estadoCuentaDto.MontoOriginal;
                    estadoCuentaDto.MontoOriginalString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    decimalValue = (decimal)estadoCuentaDto.BaseImponible;
                    estadoCuentaDto.BaseImponibleString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                    estadoCuentaDto.searchText = estadoCuentaDto.Rpdct + "-" + estadoCuentaDto.Rpdoc.ToString() + "- Cliente: " + cliente.Nombre.Trim() + "- Saldo: " + estadoCuentaDto.SaldoString;


                    item.CobEstadoCuentaDto = estadoCuentaDto;

                }

            }





            Metadata metadata = new Metadata
            {
                TotalCount = listaCobGrabacionCobranzas.TotalCount,
                PageSize = listaCobGrabacionCobranzas.PageSize,
                CurrentPage = listaCobGrabacionCobranzas.CurrentPage,
                TotalPage = listaCobGrabacionCobranzas.TotalPage,
                HasNextPage = listaCobGrabacionCobranzas.HasNextPage,
                HasPreviousPage = listaCobGrabacionCobranzas.HasPreviousPage,
                NextPageUrl = "",       // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),
                PreviousPageUrl = ""    // _uriService.GetGeneralCobranzaPaginationUri(filters, "").ToString(),
            };

            ApiResponse<IEnumerable<CobGrabacionCobranzaDto>> response = new ApiResponse<IEnumerable<CobGrabacionCobranzaDto>>(listaCobGrabacionCobranzasDto)
            {
                Meta = metadata
            };

            return Ok(response);
        }



        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Insert(CobGrabacionCobranzaDto cobGrabacionCobranzaDto)
        {
            CobGrabacionCobranzaDto resultDto = new CobGrabacionCobranzaDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };
            ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto);

            try
            {

                CobGeneralCobranza generalCobranza = await _generalCobranzaService.GetGeneralCobranzaPorDocumento((long)cobGrabacionCobranzaDto.Documento);

                if (cobGrabacionCobranzaDto.Transaccion == "RU" && generalCobranza.FlagPagoMas!=true)
                {
                    OfdCotizacion cotizacion = new OfdCotizacion();
                  

                    cotizacion = await _ofdCotizacionService.GetCotizacion(cobGrabacionCobranzaDto.Cotizacion);

                    if (cotizacion != null)
                    {
                        if (cotizacion.IdCliente == generalCobranza.IdCliente)
                        {
                            metadata.IsValid = true;
                            metadata.Message = "";
                          
                        }
                        else
                        {
                            metadata.IsValid = false;
                            metadata.Message = "Cotizacion no pertenece a este cliente!!! " + generalCobranza.IdCliente;
                            response.Meta = metadata;
                            response.Data = resultDto;
                            return Ok(response);
                        }

                    }
                    else
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Cotizacion no existe!!!";
                        response.Meta = metadata;
                        response.Data = resultDto;

                        return Ok(response);
                    }

                }





                CobGrabacionCobranzas cobGrabacionCobranza = _mapper.Map<CobGrabacionCobranzas>(cobGrabacionCobranzaDto);

      
                MtrTipoMoneda tipomoneda = await _mtrTipoMonedaService.GetById((long)generalCobranza.IdMtrTipoMoneda);

                bool dividirPagoImpuesto = false;
                CobEstadoDeCuenta estadoCuenta = await _cobEstadoCuentaService.GetEstadoCuentaById(cobGrabacionCobranzaDto.DocAfecta);
                if (estadoCuenta != null)
                {



                    if (cobGrabacionCobranzaDto.Transaccion != "RU")
                    {

                        if (generalCobranza.IdTipoTransaccion != "RET")
                        {
                            bool existeMonedaDocumentoMonedaPago = await _cobMatrixMonedaValidaPagoService.ExisteMonedaDocumentoMonedaPago(estadoCuenta.Moneda, tipomoneda.Descripcion);
                            if (!existeMonedaDocumentoMonedaPago)
                            {
                                metadata.IsValid = false;

                                metadata.Message = "Esta intentando grabar cobro en moneda no valida a el Recibo";

                                response.Meta = metadata;
                                return Ok(response);
                            }

                            decimal totalAfectadoDocumento = _cobGrabacionCobranzasService.TotalAfectadoDocumento((long)cobGrabacionCobranzaDto.Documento, cobGrabacionCobranzaDto.DocAfecta);
                            if (totalAfectadoDocumento + (decimal)cobGrabacionCobranzaDto.Monto > (decimal)estadoCuenta.Rpaap)
                            {
                                metadata.IsValid = false;

                                metadata.Message = "Esta intentando grabar monto superior al saldo del documento:" + "Total registrado en recibo: " + totalAfectadoDocumento.ToString() + "Saldo documento: " + estadoCuenta.Rpaap.ToString();
                                return Ok(response);
                            }

                        }

                    }


                    if (cobGrabacionCobranzaDto.Monto > estadoCuenta.BaseImponible && cobGrabacionCobranzaDto.Transaccion != "RE" && tipomoneda.Descripcion == estadoCuenta.Moneda)
                    {
                        dividirPagoImpuesto = true;
                    }

                }

                if (!dividirPagoImpuesto)
                {
                    cobGrabacionCobranza.PagoCorrespondeIva = false;
                    CobGrabacionCobranzas cobranza = await _cobGrabacionCobranzasService.Insert(cobGrabacionCobranza);
                    if (cobranza != null)
                    {
                        resultDto = _mapper.Map<CobGrabacionCobranzaDto>(cobranza);
                        metadata.IsValid = true;
                        metadata.Message = "Creado Satisfactoriamente";

                    }
                    else
                    {
                        metadata.IsValid = false;

                        metadata.Message = "Registro No actualizado";

                    }
                }
                else
                {



                    CobGrabacionCobranzas cobGrabacionCobranzaImpuesto = _mapper.Map<CobGrabacionCobranzas>(cobGrabacionCobranzaDto);


                    decimal? montoGrabado = cobGrabacionCobranza.Monto;
                    cobGrabacionCobranza.Monto = estadoCuenta.BaseImponible;


                    cobGrabacionCobranza.PagoCorrespondeIva = false;
                    CobGrabacionCobranzas cobranza = await _cobGrabacionCobranzasService.Insert(cobGrabacionCobranza);


                    cobGrabacionCobranzaImpuesto.Monto = montoGrabado - estadoCuenta.BaseImponible;
                    cobGrabacionCobranzaImpuesto.PagoCorrespondeIva = true;
                    CobGrabacionCobranzas cobranzaImpuesto = await _cobGrabacionCobranzasService.Insert(cobGrabacionCobranzaImpuesto);

                    if (cobranza != null)
                    {
                        resultDto = _mapper.Map<CobGrabacionCobranzaDto>(cobranza);
                        metadata.IsValid = true;
                        metadata.Message = "Creado Satisfactoriamente";
                    }
                    else
                    {
                        metadata.IsValid = false;

                        metadata.Message = "Registro No actualizado";
                    }

                }

                //ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto)
                //{
                //    Meta = metadata,
                //};
                response.Meta = metadata;
                response.Data = resultDto;

                return Ok(response);
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;

                metadata.Message = ex.InnerException.Message;

                response.Meta = metadata;
                response.Data = resultDto;
                //ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto)
                //{
                //    Meta = metadata,
                //};
                return Ok(response);

            }





        }




        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Update(CobGrabacionCobranzaDto cobGrabacionCobranzaDto)
        {
            CobGrabacionCobranzaDto resultDto = new CobGrabacionCobranzaDto();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };





            ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto);






            CobGrabacionCobranzas cobGrabacionCobranza = _mapper.Map<CobGrabacionCobranzas>(cobGrabacionCobranzaDto);

            CobGeneralCobranza generalCobranza = await _generalCobranzaService.GetGeneralCobranzaPorDocumento((long)cobGrabacionCobranza.Documento);
            MtrTipoMoneda tipomoneda = await _mtrTipoMonedaService.GetById((long)generalCobranza.IdMtrTipoMoneda);

            CobEstadoDeCuenta estadoCuenta = await _cobEstadoCuentaService.GetEstadoCuentaById(cobGrabacionCobranzaDto.DocAfecta);
            if (estadoCuenta != null)
            {

                CobGrabacionCobranzas grabacionActual = await _cobGrabacionCobranzasService.GetById(cobGrabacionCobranzaDto.Id);




                if (cobGrabacionCobranzaDto.Transaccion != "RU")
                {
                    if (generalCobranza.IdTipoTransaccion != "RET")
                    {

                        bool existeMonedaDocumentoMonedaPago = await _cobMatrixMonedaValidaPagoService.ExisteMonedaDocumentoMonedaPago(estadoCuenta.Moneda, tipomoneda.Descripcion);
                        if (!existeMonedaDocumentoMonedaPago)
                        {
                            metadata.IsValid = false;

                            metadata.Message = "Esta intentando grabar cobro en moneda no valida a el Recibo";

                            response.Meta = metadata;
                            return Ok(response);
                        }
                    }


                    decimal totalAfectadoDocumento = _cobGrabacionCobranzasService.TotalAfectadoDocumento((long)cobGrabacionCobranzaDto.Documento, cobGrabacionCobranzaDto.DocAfecta);


                    decimal totalAfectadoDocumentoResta = totalAfectadoDocumento - (decimal)grabacionActual.Monto;


                    if (totalAfectadoDocumentoResta + (decimal)cobGrabacionCobranzaDto.Monto > (decimal)estadoCuenta.Rpaap)
                    {
                        metadata.IsValid = false;

                        metadata.Message = "Esta intentando grabar monto superior al saldo del documento:" + "Total registrado en recibo: " + totalAfectadoDocumento.ToString() + "Saldo documento: " + estadoCuenta.Rpaap.ToString();

                        response.Meta = metadata;
                        return Ok(response);
                    }

                }


            }


            CobGrabacionCobranzas grabacionCobranzaActual = await _cobGrabacionCobranzasService.GetById(cobGrabacionCobranzaDto.Id);

            if (grabacionCobranzaActual.DocumentoSap.Length > 1)
            {
                metadata.IsValid = false;

                metadata.Message = "Esta intentando modificar un cobro ya contabilizado";

                response.Meta = metadata;
                return Ok(response);
            }


            CobGrabacionCobranzas cobranza = await _cobGrabacionCobranzasService.Update(cobGrabacionCobranza);
            if (cobranza != null)
            {
                resultDto = _mapper.Map<CobGrabacionCobranzaDto>(cobranza);
                metadata.IsValid = true;
                metadata.Message = "Actualizado Satisfactoriamente";
            }
            else
            {
                metadata.IsValid = false;

                metadata.Message = "Registro No actualizado";
            }



            //ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto)
            //{
            //    Meta = metadata,
            //};
            response.Meta = metadata;
            response.Data = resultDto;
            return Ok(response);

        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Delete(CobGrabacionCobranzaDto cobGrabacionCobranzaDto)
        {
            CobGrabacionCobranzaDto resultDto = new CobGrabacionCobranzaDto();
            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            CobGrabacionCobranzas cobGrabacionCobranza = _mapper.Map<CobGrabacionCobranzas>(cobGrabacionCobranzaDto);


            bool cobranza = await _cobGrabacionCobranzasService.Delete(cobGrabacionCobranza.Id);
            if (cobranza)
            {

                metadata.IsValid = true;
                metadata.Message = "Actualizado Satisfactoriamente";
            }
            else
            {
                metadata.IsValid = false;

                metadata.Message = "Registro No actualizado";
            }



            ApiResponse<CobGrabacionCobranzaDto> response = new ApiResponse<CobGrabacionCobranzaDto>(resultDto)
            {
                Meta = metadata,
            };
            return Ok(response);

        }

    }
}