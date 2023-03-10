using AppService.Api.Responses;
using AppService.Api.Utility;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.SapAnticipo;
using AppService.Core.Entities;
using AppService.Core.Enumerations;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Services;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using DinkToPdf;
using DinkToPdf.Contracts;
using SelectPdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class GeneralCobranzasController : ControllerBase
    {
        private readonly IGeneralCobranzaService _generalCobranzaService;
        private readonly ICobGrabacionCobranzasService _cobGrabacionCobranzasService;
        private readonly ICobAdjuntosCobranzaService _cobAdjuntosCobranzaService;
        private readonly IMtrTipoMonedaService _mtrTipoMonedaService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IMtrClienteService _mtrClienteService;
        private readonly IMtrVendedorService _mtrVendedorService;
        private readonly IMtrBancosService _mtrBancosService;
        private readonly ICobSysfileService _cobSysfileService;
        private readonly ICobTipoTransaccionService _cobTipoTransaccionService;
        private readonly IConverter _converter;
        private readonly ISapClient _sapClient;
        private readonly ICobPagosRetencionesService _cobPagosRetencionesService;
        private readonly PaginationOptions _paginationOptions;

        public GeneralCobranzasController(IGeneralCobranzaService generalCobranzaService,
                                            ICobGrabacionCobranzasService cobGrabacionCobranzasService,
                                            ICobAdjuntosCobranzaService cobAdjuntosCobranzaService,
                                             IMtrTipoMonedaService mtrTipoMonedaService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IMtrClienteService mtrClienteService,
                                            IMtrVendedorService mtrVendedorService,
                                            IMtrBancosService mtrBancosService,
                                            ICobSysfileService cobSysfileService,
                                            ICobTipoTransaccionService cobTipoTransaccionService,
                                             IOptions<PaginationOptions> options,
                                            IConverter converter,
                                            ISapClient sapClient,
                                            ICobPagosRetencionesService cobPagosRetencionesService)
        {
            _generalCobranzaService = generalCobranzaService;
            _cobGrabacionCobranzasService = cobGrabacionCobranzasService;
            _cobAdjuntosCobranzaService = cobAdjuntosCobranzaService;
            _mtrTipoMonedaService = mtrTipoMonedaService;
            _mapper = mapper;
            _uriService = uriService;
            _mtrClienteService = mtrClienteService;
            _mtrVendedorService = mtrVendedorService;
            _mtrBancosService = mtrBancosService;
            _cobSysfileService = cobSysfileService;
            _cobTipoTransaccionService = cobTipoTransaccionService;
            _converter = converter;
            _sapClient = sapClient;
            _cobPagosRetencionesService = cobPagosRetencionesService;
            _paginationOptions = options.Value;
        }

        /// <summary>
        /// Retorna los datos generales de Cobros
        /// </summary>
        /// <param name="filters">Filtros a aplicar</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobGeneralCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetGeneralCobranzas([FromQuery] GeneralCobranzaQueryFilter filters)
        {


            IEnumerable<CobGeneralCobranza> generalCobranzas = await _generalCobranzaService.GetGeneralCobranza(filters);

            IEnumerable<CobGeneralCobranzaDto> generalCobranzasDtos = _mapper.Map<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzas);

            PagedList<CobGeneralCobranzaDto> pagedCobranzas = PagedList<CobGeneralCobranzaDto>.Create(generalCobranzasDtos, filters.PageNumber, filters.PageSize);

            Metadata metadata = new Metadata
            {
                TotalCount = pagedCobranzas.TotalCount,
                PageSize = pagedCobranzas.PageSize,
                CurrentPage = pagedCobranzas.CurrentPage,
                TotalPage = pagedCobranzas.TotalPage,
                HasNextPage = pagedCobranzas.HasNextPage,
                HasPreviousPage = pagedCobranzas.HasPreviousPage,
                NextPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
                PreviousPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
            };

            //ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzasDtos);
            ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(pagedCobranzas)
            {
                Meta = metadata
            };

            Response.Headers.Add("x-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(response);

        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetGeneralCobranza(int id)
        {


            CobGeneralCobranza generalCobranza = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(id);
            CobGeneralCobranzaDto generalCobranzasDto = _mapper.Map<CobGeneralCobranzaDto>(generalCobranza);

            ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDto);
            return Ok(response);
        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Insert(CobGeneralCobranzaDto generalCobranzaDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };
            try
            {
                generalCobranzaDto.FechaLmcxC = DateTime.Now;
                CobGeneralCobranza generalCobranza = _mapper.Map<CobGeneralCobranza>(generalCobranzaDto);

                Metadata metaValidacion = await _generalCobranzaService.ValidaInsertCobranza(generalCobranza);
                if (metaValidacion.IsValid)
                {
                    CobGeneralCobranza result = await _generalCobranzaService.InsertGeneralCobranza(generalCobranza);

                    generalCobranzaDto = _mapper.Map<CobGeneralCobranzaDto>(result);


                }

                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzaDto)
                {
                    Meta = metaValidacion
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzaDto)
                {
                    Meta = metadata
                };
                return Ok(response);

            }

        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Update(CobGeneralCobranzaDto generalCobranzaDto)
        {

            CobGeneralCobranza generalCobranza = _mapper.Map<CobGeneralCobranza>(generalCobranzaDto);


            Metadata metaValidacion = await _generalCobranzaService.ValidaUpdateCobranza(generalCobranza);
            if (metaValidacion.IsValid)
            {
                CobGeneralCobranza result = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranza);
                generalCobranzaDto = _mapper.Map<CobGeneralCobranzaDto>(result);

            }



            ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzaDto)
            {
                Meta = metaValidacion
            };
            return Ok(response);

        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetAllGeneralCobranzas(GeneralCobranzaQueryFilter filters)
        {




            IEnumerable<CobGeneralCobranza> generalCobranzas = await _generalCobranzaService.GetGeneralCobranza(filters);




            IEnumerable<CobGeneralCobranzaDto> generalCobranzasDtos = _mapper.Map<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzas);

            DateTime actual = DateTime.Now;
            DateTime final;
            foreach (CobGeneralCobranzaDto item in generalCobranzasDtos)
            {
                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(item.IdCliente);
                MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1.Trim());
                item.NombreCliente = cliente.Nombre.Trim();
                item.IdCliente = item.IdCliente.Trim();

                item.FechaTransaccionIso = item.FechaTransaccion.ToString("yyyy-MM-dd'T'HH:mm:ss zzz");
                item.FechaTransaccionString = item.FechaTransaccion.ToShortDateString();

                item.NombreVendedor = vendedor.Nombre;
                item.vendedor = vendedor.Codigo;
                decimal decimalValue = item.MontoTransaccion;
                item.MontoTransaccionString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimal? detalleValue = item.TotalDetalleCobrado;
                item.TotalDetalleCobradoString = string.Format("{0:N}", detalleValue);

                item.SearchText = item.IdCliente + "-" + item.NombreCliente + "-" + item.NombreVendedor + "-" + item.Documento.ToString();

                CobGeneralCobranza itemGgeneralCobranzas = _mapper.Map<CobGeneralCobranza>(item);
                item.Status = _generalCobranzaService.EstatusRecibo(itemGgeneralCobranzas);

                item.OrdenListar = 10;
                if (item.Status == "GRABACION")
                {
                    item.OrdenListar = 0;
                }
                else if (item.Status == "ENVIADO_ADMINISTRACION")
                {
                    item.OrdenListar = 1;
                }
                else if(item.Status == "CONFIRMADO")
                {
                    item.OrdenListar = 2;
                }
                else if (item.Status == "APROBADO")
                {
                    item.OrdenListar = 3;
                }
                else if (item.Status == "CONFIRMADO")
                {
                    item.OrdenListar = 4;
                }





                MtrBancos banco = await _mtrBancosService.GetByCodigo(item.IdBanco);
                item.NombreBanco = banco.Nombre;

                CobTipoTransaccion tipoTransaccion = await _cobTipoTransaccionService.GetById(item.IdTipoTransaccion);
                item.NombreTipoTransaccion = tipoTransaccion.NombreTipoTransaccion;
                item.FlagImpuesto = tipoTransaccion.FlagImpuesto;


                MtrTipoMoneda mtrTipoMoneda = await _mtrTipoMonedaService.GetById((long)item.IdMtrTipoMoneda);
                item.NombreTipoMoneda = mtrTipoMoneda.Descripcion;





            }
            final = DateTime.Now;

            int transcurrido = DateTime.Compare(final, actual);
            var pagedCobranzasOrdenado = generalCobranzasDtos.OrderBy(x => x.OrdenListar).ThenByDescending(x => x.Documento).ToList();



            PagedList<CobGeneralCobranzaDto> pagedCobranzas = PagedList<CobGeneralCobranzaDto>.Create(pagedCobranzasOrdenado, filters.PageNumber, filters.PageSize);


          


            Metadata metadata = new Metadata
            {
                TotalCount = pagedCobranzas.TotalCount,
                PageSize = pagedCobranzas.PageSize,
                CurrentPage = pagedCobranzas.CurrentPage,
                TotalPage = pagedCobranzas.TotalPage,
                HasNextPage = pagedCobranzas.HasNextPage,
                HasPreviousPage = pagedCobranzas.HasPreviousPage,
                NextPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
                PreviousPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
            };


            ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(pagedCobranzas)
            {
                Meta = metadata
            };



            return Ok(response);

        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetGeneralCobranzaPendienteVerificarPago(GeneralCobranzaQueryFilter filters)
        {


            IEnumerable<CobGeneralCobranza> generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPendienteVerificarPago(filters);


            IEnumerable<CobGeneralCobranzaDto> generalCobranzasDtos = _mapper.Map<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzas);




            DateTime actual = DateTime.Now;
            DateTime final;
            foreach (CobGeneralCobranzaDto item in generalCobranzasDtos)
            {
                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(item.IdCliente);
                MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);
                item.NombreCliente = cliente.Nombre.Trim();
                item.IdCliente = item.IdCliente.Trim();
                item.FechaTransaccionIso = item.FechaTransaccion.ToString("yyyy-MM-dd'T'HH:mm:ss zzz");
                item.FechaTransaccionString = item.FechaTransaccion.ToShortDateString();
                item.NombreVendedor = vendedor.Nombre;
                item.vendedor = vendedor.Codigo;



                decimal decimalValue = item.MontoTransaccion;
                item.MontoTransaccionString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimal? detalleValue = item.TotalDetalleCobrado;
                item.TotalDetalleCobradoString = string.Format("{0:N}", detalleValue);
                CobGeneralCobranza itemGgeneralCobranzas = _mapper.Map<CobGeneralCobranza>(item);
                item.Status = _generalCobranzaService.EstatusRecibo(itemGgeneralCobranzas);

                MtrBancos banco = await _mtrBancosService.GetByCodigo(item.IdBanco);
                item.NombreBanco = banco.Nombre;

                CobTipoTransaccion tipoTransaccion = await _cobTipoTransaccionService.GetById(item.IdTipoTransaccion);
                item.NombreTipoTransaccion = tipoTransaccion.NombreTipoTransaccion;
                item.FlagImpuesto = tipoTransaccion.FlagImpuesto;
                item.FlagActivaVerificacion = tipoTransaccion.FlagActivaVerificacion;

                MtrTipoMoneda mtrTipoMoneda = await _mtrTipoMonedaService.GetById((long)item.IdMtrTipoMoneda);
                item.NombreTipoMoneda = mtrTipoMoneda.Descripcion;





            }

            generalCobranzasDtos = generalCobranzasDtos.Where(x => x.FlagActivaVerificacion == true).ToList();


            generalCobranzasDtos = generalCobranzasDtos.OrderByDescending(x => x.FechaRegistro);

            filters.PageNumber = 0;
            filters.PageSize = 100;

            PagedList<CobGeneralCobranzaDto> pagedCobranzas = PagedList<CobGeneralCobranzaDto>.Create(generalCobranzasDtos, filters.PageNumber, filters.PageSize);


            final = DateTime.Now;

            int transcurrido = DateTime.Compare(final, actual);



            Metadata metadata = new Metadata
            {
                TotalCount = pagedCobranzas.TotalCount,
                PageSize = pagedCobranzas.PageSize,
                CurrentPage = pagedCobranzas.CurrentPage,
                TotalPage = pagedCobranzas.TotalPage,
                HasNextPage = pagedCobranzas.HasNextPage,
                HasPreviousPage = pagedCobranzas.HasPreviousPage,
                NextPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
                PreviousPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
            };


            ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(pagedCobranzas)
            {
                Meta = metadata
            };



            return Ok(response);

        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetGeneralCobranzaPendienteAprobarPago(GeneralCobranzaQueryFilter filters)
        {


            IEnumerable<CobGeneralCobranza> generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPendienteAprobarPago(filters);


            IEnumerable<CobGeneralCobranzaDto> generalCobranzasDtos = _mapper.Map<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzas);




            DateTime actual = DateTime.Now;
            DateTime final;
            foreach (CobGeneralCobranzaDto item in generalCobranzasDtos)
            {
                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(item.IdCliente);
                MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);
                item.NombreCliente = cliente.Nombre.Trim();
                item.IdCliente = item.IdCliente.Trim();
                item.FechaTransaccionIso = item.FechaTransaccion.ToString("yyyy-MM-dd'T'HH:mm:ss zzz");
                item.FechaTransaccionString = item.FechaTransaccion.ToShortDateString();
                item.NombreVendedor = vendedor.Nombre;
                item.vendedor = vendedor.Codigo;

                item.SearchText = item.IdCliente + "-" + item.NombreCliente + "-" + item.NombreVendedor + "-" + item.Documento.ToString();

                decimal decimalValue = item.MontoTransaccion;
                item.MontoTransaccionString = string.Format("{0:N}", decimalValue); // 1,234,567.00
                decimal? detalleValue = item.TotalDetalleCobrado;
                item.TotalDetalleCobradoString = string.Format("{0:N}", detalleValue);

                CobGeneralCobranza itemGgeneralCobranzas = _mapper.Map<CobGeneralCobranza>(item);
                item.Status = _generalCobranzaService.EstatusRecibo(itemGgeneralCobranzas);

                MtrBancos banco = await _mtrBancosService.GetByCodigo(item.IdBanco);
                item.NombreBanco = banco.Nombre;

                CobTipoTransaccion tipoTransaccion = await _cobTipoTransaccionService.GetById(item.IdTipoTransaccion);
                item.NombreTipoTransaccion = tipoTransaccion.NombreTipoTransaccion;
                item.FlagImpuesto = tipoTransaccion.FlagImpuesto;
                item.FlagActivaVerificacion = tipoTransaccion.FlagActivaVerificacion;

                MtrTipoMoneda mtrTipoMoneda = await _mtrTipoMonedaService.GetById((long)item.IdMtrTipoMoneda);
                item.NombreTipoMoneda = mtrTipoMoneda.Descripcion;





            }

            generalCobranzasDtos = generalCobranzasDtos.Where(x => x.FlagActivaVerificacion == true).ToList();



            generalCobranzasDtos = generalCobranzasDtos.OrderByDescending(x => x.FechaRegistro);

            filters.PageNumber = 0;
            filters.PageSize = 100;

            PagedList<CobGeneralCobranzaDto> pagedCobranzas = PagedList<CobGeneralCobranzaDto>.Create(generalCobranzasDtos, filters.PageNumber, filters.PageSize);


            final = DateTime.Now;

            int transcurrido = DateTime.Compare(final, actual);



            Metadata metadata = new Metadata
            {
                TotalCount = pagedCobranzas.TotalCount,
                PageSize = pagedCobranzas.PageSize,
                CurrentPage = pagedCobranzas.CurrentPage,
                TotalPage = pagedCobranzas.TotalPage,
                HasNextPage = pagedCobranzas.HasNextPage,
                HasPreviousPage = pagedCobranzas.HasPreviousPage,
                NextPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
                PreviousPageUrl = _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
            };


            ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(pagedCobranzas)
            {
                Meta = metadata
            };



            return Ok(response);

        }



        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetGeneralCobranzasByDocumento(GeneralCobranzaQueryFilter filters)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };
            CobGeneralCobranzaDto result = new CobGeneralCobranzaDto();
            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();


            if (generalCobranzas != null)
            {
                generalCobranzasDtos = _mapper.Map<CobGeneralCobranzaDto>(generalCobranzas);



                MtrCliente cliente = await _mtrClienteService.GetByIdAsync(generalCobranzasDtos.IdCliente);
                MtrVendedor vendedor = await _mtrVendedorService.GetByIdAsync(cliente.Vendedor1);
                generalCobranzasDtos.NombreCliente = cliente.Nombre.Trim();
                generalCobranzasDtos.IdCliente = generalCobranzasDtos.IdCliente.Trim();
                generalCobranzasDtos.FechaTransaccionIso = generalCobranzasDtos.FechaTransaccion.ToString("yyyy-MM-dd'T'HH:mm:ss zzz");
                generalCobranzasDtos.FechaTransaccionString = generalCobranzasDtos.FechaTransaccion.ToShortDateString();
                generalCobranzasDtos.NombreVendedor = vendedor.Nombre;
                decimal decimalValue = generalCobranzasDtos.MontoTransaccion;
                generalCobranzasDtos.MontoTransaccionString = string.Format("{0:N}", decimalValue); // 1,234,567.00metadata
                decimal? detalleValue = generalCobranzasDtos.TotalDetalleCobrado;
                generalCobranzasDtos.TotalDetalleCobradoString = string.Format("{0:N}", detalleValue);

                metadata.IsValid = true;
                metadata.Message = "";
            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
            }




            ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
            {
                Meta = metadata
            };



            return Ok(response);

        }




        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Delete(CobGeneralCobranzaDto generalCobranzaDto)
        {

            CobGeneralCobranza generalCobranza = _mapper.Map<CobGeneralCobranza>(generalCobranzaDto);

            Metadata meta = new Metadata
            {
                Message = "",
                IsValid = false
            };


            long id = generalCobranza.Documento;

            CobGeneralCobranza cobranza = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(id);
            if (cobranza == null)
            {
                meta.Message = "Recibo no existe";
                meta.IsValid = false;
                ApiResponse<bool> response = new ApiResponse<bool>(false)
                {
                    Meta = meta
                };
                return Ok(response);
            }

            string status = _generalCobranzaService.EstatusRecibo(generalCobranza);


            if (status == Enum.GetName(typeof(EstatusReciboEnum), EstatusReciboEnum.GRABACION))
            {
                bool result = await _generalCobranzaService.DeleteGeneralCobranza(id);
                meta.Message = "Recibo Borrado Satisfactotriamente";
                meta.IsValid = result;
                ApiResponse<bool> response = new ApiResponse<bool>(result)
                {
                    Meta = meta
                };
                return Ok(response);
            }
            else
            {
                meta.Message = "Recibo no puede ser eliminado si no esta en GRABACION!!!";
                meta.IsValid = false;
                ApiResponse<bool> response = new ApiResponse<bool>(false)
                {
                    Meta = meta
                };
                return Ok(response);
            }


        }

        private async Task GeneratePDF(List<CobGeneralCobranzaDto> cobGeneralCobranzaDto)
        {

            try
            {

                string html = TemplateGenerator.GetHTMLStringRecibo(cobGeneralCobranzaDto);


                HtmlToPdf oHtmlToPdf = new HtmlToPdf();
                oHtmlToPdf.Options.MarginTop = 4;

                PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(html);

                byte[] pdf = oPdfDocument.Save();
                oPdfDocument.Close();

                string imageFullName = @"D:\Moore\Adjuntos\ListRecibos_Report.pdf";
                //creo el fichero
                await System.IO.File.WriteAllBytesAsync(imageFullName, pdf);

                //File(pdf, "application/pdf", @"D:\Moore\Adjuntos\ListRecibos_Report.pdf");


            }
            catch (Exception e)
            {
                string message = e.Message;
                throw;
            }



        }
        private void CreatePDF(List<CobGeneralCobranzaDto> cobGeneralCobranzaDto)
        {

            try
            {
                GlobalSettings globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10 },
                    DocumentTitle = "PDF Report",
                    Out = @"D:\PDFCreator\ListRecibos_Report.pdf"
                };

                ObjectSettings objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = TemplateGenerator.GetHTMLStringRecibo(cobGeneralCobranzaDto),
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
                };

                HtmlToPdfDocument pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };

                _converter.Convert(pdf);


            }
            catch (Exception e)
            {
                string message = e.Message;
                throw;
            }



        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> EnviarAdmon(GeneralCobranzaQueryFilter filters)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();
            CobAdjuntosCobranza Adjunto = new CobAdjuntosCobranza();
            CobAdjuntosCobranza AdjuntoJpg = new CobAdjuntosCobranza();
            if (generalCobranzas != null)
            {


                bool reciboTieneCobro = _cobGrabacionCobranzasService.ReciboTieneCobro(filters.Documento);
                if (reciboTieneCobro == false)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC aun no tiene cobranza y / o retenciones grabada.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };



                    return Ok(response);
                }



                bool documentoTieneAdjunto = await _cobAdjuntosCobranzaService.DocumentoTieneAdjunto(filters.Documento);
                if (documentoTieneAdjunto == false)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC aun no tiene adjuntos.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };



                    return Ok(response);
                }


                if (generalCobranzas.IdTipoTransaccion == "RET")
                {
                    bool GrabacionCobranzasTieneRetencionCero = await _cobGrabacionCobranzasService.GrabacionCobranzasTieneRetencionCero(filters.Documento);


                    if (GrabacionCobranzasTieneRetencionCero)
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Este RC tiene monto cero en su detalle o retencion";
                        ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                        {
                            Meta = metadata
                        };

                        return Ok(response);
                    }
                }



                ReciboDto recibo = await _generalCobranzaService.GeneraReciboDto(filters.Documento);
                Metadata geberaPdf = _generalCobranzaService.GeneraPdfRecibo(recibo, "_Enviado");
                if (geberaPdf.IsValid)
                {


                    decimal? totalDetalleCobrado = generalCobranzas.TotalDetalleCobrado;
                    if (totalDetalleCobrado != 0)
                    {
                        generalCobranzas.FlagPagoMas = true;
                    }
                    else
                    {
                        generalCobranzas.FlagPagoMas = false;
                    }

                    generalCobranzas.FlagEnviado = true;

                    generalCobranzas.FechaEnviado = DateTime.Now;

                    if (generalCobranzas.IdTipoTransaccion == "RET")
                    {
                        generalCobranzas.FlagConfirmado = true;

                        generalCobranzas.FechaConfirmado = DateTime.Now;

                        generalCobranzas.UsuarioConfirma = filters.UsuarioConectado;
                    }




                    CobGeneralCobranza resultgeneralCobranzas = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);

                    if (totalDetalleCobrado > 0)
                    {
                        CobGrabacionCobranzas cobGrabacionCobranzas = new CobGrabacionCobranzas
                        {
                            Documento = generalCobranzas.Documento,
                            Transaccion = "RU",
                            Monto = totalDetalleCobrado,
                            PagoCorrespondeIva = false,
                            PagoDeMas=true
                        };
                        await _cobGrabacionCobranzasService.Insert(cobGrabacionCobranzas);

                    }



                    //ADJUNTAMOS EL RC///////////////////////////////
                    Adjunto.Documento = filters.Documento;
                    Adjunto.IdTipoDocumento = 20;
                    Adjunto.NombreArchivo = "RC_" + filters.Documento.ToString() + "_Enviado" + ".pdf";
                    Adjunto.Archivo = null;
                    Adjunto.IdUsuarioCreacion = "RR105841";// User.Identity.Name;
                    Adjunto.FechaCreacion = DateTime.Now;
                    Adjunto.Ruta = _paginationOptions.FolderDocumentation + "\\";
                    CobAdjuntosCobranza cobranzaAdjunto = await _cobAdjuntosCobranzaService.Insert(Adjunto);



                    metadata.IsValid = true;
                    metadata.Message = "Enviado a la administradora con éxito.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = geberaPdf.IsValid;
                    metadata.Message = geberaPdf.Message;
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }






        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> ConfirmarPago(GeneralCobranzaQueryFilter filters)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();

            if (generalCobranzas != null)
            {





                generalCobranzas.FlagConfirmado = true;

                generalCobranzas.FechaConfirmado = DateTime.Now;

                generalCobranzas.UsuarioConfirma = filters.UsuarioConectado;

                CobGeneralCobranza resultgeneralCobranzas = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);



                metadata.IsValid = true;
                metadata.Message = "Recibo Confirmado con éxito.";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);



            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }






        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> DevolverPagoGeneralCobranzas(GeneralCobranzaQueryFilter filters)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();

            if (generalCobranzas != null)
            {


                generalCobranzas.FlagEnviado = false;

                generalCobranzas.FechaEnviado = null;


                generalCobranzas.FlagConfirmado = false;

                generalCobranzas.FechaConfirmado = null;

                generalCobranzas.UsuarioConfirma = null;

                CobGeneralCobranza resultgeneralCobranzas = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);



                metadata.IsValid = true;
                metadata.Message = "Recibo Devuelto con éxito.";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);



            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }






        }


        public async Task<DateTime?> FechaContabilizacion()
        {
            DateTime? fechaContabilizacion;
            CobSysfile Sysfile = new CobSysfile();
            Sysfile = await _cobSysfileService.GetById(1);
            if (DateTime.Today > Sysfile.FechaLmcxC)
            {
                fechaContabilizacion = Sysfile.FechaLmcxC;

            }
            else
            {

                fechaContabilizacion = DateTime.Now;
            }

            return fechaContabilizacion;

        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AprobarPagonGeneralCobranzas(GeneralCobranzaQueryFilter filters)
        {



            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();
            CobAdjuntosCobranza Adjunto = new CobAdjuntosCobranza();
            CobAdjuntosCobranza AdjuntoJpg = new CobAdjuntosCobranza();
            CobSysfile Sysfile = new CobSysfile();

            if (generalCobranzas != null)
            {

              

                Sysfile = await _cobSysfileService.GetById(1);

                if (Sysfile == null)
                {


                    metadata.IsValid = false;
                    metadata.Message = "Archivo SYSFILE de Recibos de Cobro no está configurado. Comunicarse con cuentas por cobrar.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);

                }
                else
                {
                    if (Sysfile.FlagAprobarRc == false)
                    {

                        metadata.IsValid = false;
                        metadata.Message = "No se pueden aprobar recibos de cobro, en estos momentos estamos en cierre.";
                        ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                        {
                            Meta = metadata
                        };

                        return Ok(response);
                    }
                }




                if (!_cobGrabacionCobranzasService.ReciboTieneCobro(filters.Documento))
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC aun no tiene cobranza y / o retenciones grabada.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };



                    return Ok(response);
                }

                if (generalCobranzas.IdTipoTransaccion == "RET")
                {

                    if (await _cobGrabacionCobranzasService.GrabacionCobranzasTieneRetencionCero(filters.Documento))
                    {
                        metadata.IsValid = false;
                        metadata.Message = "Este RC tiene monto cero en su detalle de cobro o retencion!!";
                        ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                        {
                            Meta = metadata
                        };

                        return Ok(response);
                    }


                }

                //valida pago de mas y genera anticipo automat

                decimal? totalDetalleCobrado = generalCobranzas.TotalDetalleCobrado;
                if (totalDetalleCobrado != 0)
                {
                    generalCobranzas.FlagPagoMas = true;
                }
                else
                {
                    generalCobranzas.FlagPagoMas = false;
                }

                generalCobranzas.FechaLm = DateTime.Today;
                generalCobranzas.FechaLmcxC = DateTime.Today;
                generalCobranzas.UsuarioAprueba = "RR105841";// User.Identity.Name;


                //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LM COMISIONES) Y LA///////////
                //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
               // var fechaTransaccionString = generalCobranzas.FechaTransaccion.ToString("d");
                //DateTime fechaTransaccion = Convert.ToDateTime(fechaTransaccionString);
               // if ((DateTime.Today > Sysfile.FechaLm) && fechaTransaccion <= Sysfile.FechaLm)
                //{
               //     generalCobranzas.FechaLm = Sysfile.FechaLm;
                //}
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////


                //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LMCxC) Y LA///////////////////
                //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
           
                    generalCobranzas.FechaLmcxC = await FechaContabilizacion();
                    generalCobranzas.FechaLm = await FechaContabilizacion();
                
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////


                await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);

                if (totalDetalleCobrado > 0)
                {

                    if (generalCobranzas.IdTipoTransaccion == "RET")
                    {

                      
                            metadata.IsValid = false;
                            metadata.Message = "Retencion con diferencia!!";
                            ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                            {
                                Meta = metadata
                            };

                            return Ok(response);
                        


                    }

                    CobGrabacionCobranzas cobGrabacionCobranzas = new CobGrabacionCobranzas
                    {
                        Documento = generalCobranzas.Documento,
                        Transaccion = "RU",
                        Monto = totalDetalleCobrado,
                        PagoCorrespondeIva = false
                    };
                    await _cobGrabacionCobranzasService.Insert(cobGrabacionCobranzas);

                }






                ReciboDto recibo = await _generalCobranzaService.GeneraReciboDto(filters.Documento);





                ///////////////////ENVIAR RECIBO A SAP //////////////////////////////
                ///


                bool enviadoCorrectamente = false;

                string userSap = _paginationOptions.UserSap;
                string passwordSap = _paginationOptions.PasswordSap;
                string tokenSap = "";
                Metadata meta = await _sapClient.GetToken(userSap, passwordSap);
                if (meta.IsValid)
                {
                    tokenSap = meta.Message;

                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Conexion Invalida...Intente mas tarde";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


                if (recibo.CobGeneralCobranzaDto.IdTipoTransaccion != "RET")
                {
                    List<ReciboEnviarSapDto> objEnviarSap = await _generalCobranzaService.GeneraListObjectSap(recibo);
                    foreach (ReciboEnviarSapDto item in objEnviarSap)
                    {
                        enviadoCorrectamente = false;
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            IgnoreNullValues = true,
                            WriteIndented = true,
                            PropertyNameCaseInsensitive = true
                        };





                        string transaccion = item.d.Transaccion;
                        long? id = item.d.Id;
                        item.d.Transaccion = null;
                        item.d.Id = null;

                        CobGrabacionCobranzas itemGrabacionCobranzas = await _cobGrabacionCobranzasService.GetById((long)id);
                        //TODO Aqui diferenciar el objeto para RU
                        string json = JsonSerializer.Serialize(item, options);

                        StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


                        if (transaccion == "RU")
                        {

                            AnticipoEnviarSapDto itemAnticipo = new AnticipoEnviarSapDto();
                            d d = new d
                            {
                                NroRecibo = item.d.NroRecibo,
                                Sociedad = item.d.Sociedad,
                                Cliente = item.d.Cliente,
                                DocCobroSAP = item.d.DocCobroSAP,
                                FechaCobroReal = item.d.FechaCobroReal,
                                FechaContabilizacion = item.d.FechaContabilizacion,
                                Referencia = item.d.Referencia,
                                TextoCab = item.d.TextoCab,
                                CuentaBancaria = item.d.CuentaBancaria,
                                TextoPos = item.d.TextoPos,
                                Monto = item.d.Monto,
                                Moneda = item.d.Moneda
                            };
                            itemAnticipo.d = d;

                            string jsonRU = JsonSerializer.Serialize(itemAnticipo, options);

                            StringContent dataRU = new StringContent(jsonRU, Encoding.UTF8, "application/json");


                            Metadata result = await _sapClient.Post("Anticipos", tokenSap, dataRU);
                            //StringContent dataResult = new StringContent(result.Message, Encoding.UTF8, "application/json");
                            AppService.Core.DTOs.Sap.SapAnticipoResult.Application resultSapCobros = new AppService.Core.DTOs.Sap.SapAnticipoResult.Application();
                            resultSapCobros = JsonSerializer.Deserialize<AppService.Core.DTOs.Sap.SapAnticipoResult.Application>(result.Message, options);

                            string docgenerado = resultSapCobros.d.DocGenerado;
                            string ejercicioDocGenerado = resultSapCobros.d.EjercicioDocGenerado;

                            //ACTUALIZAMOS EL DOCUMENTO SAP EN LA TABLA cobGrabacionCobranza
                            itemGrabacionCobranzas.DocumentoSap = docgenerado;
                            itemGrabacionCobranzas.EjercicioDocumentoSap = ejercicioDocGenerado;
                            await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);

                            enviadoCorrectamente = result.IsValid;

                            metadata.IsValid = result.IsValid;
                            metadata.Message = result.Message;

                            if (!result.IsValid)
                            {
                                itemGrabacionCobranzas.ErrorMessage = result.Message;
                                itemGrabacionCobranzas.ObjectSend = json;
                                await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                            }



                        }
                        else
                        {
                            if (transaccion == "RE")
                            {
                                Metadata result = await _sapClient.Post("Retenciones", tokenSap, data);
                                //StringContent dataResult = new StringContent(result.Message, Encoding.UTF8, "application/json");
                                AppService.Core.DTOs.SapCobroResult.Application resultSapCobros = new AppService.Core.DTOs.SapCobroResult.Application();
                                resultSapCobros = JsonSerializer.Deserialize<AppService.Core.DTOs.SapCobroResult.Application>(result.Message, options);
                                string docgenerado = resultSapCobros.d.DocGenerado;
                                string ejercicioDocGenerado = resultSapCobros.d.EjercicioDocGenerado;



                                //ACTUALIZAMOS EL DOCUMENTO SAP EN LA TABLA cobGrabacionCobranza
                                itemGrabacionCobranzas.DocumentoSap = docgenerado;
                                itemGrabacionCobranzas.EjercicioDocumentoSap = ejercicioDocGenerado;
                                await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                                enviadoCorrectamente = result.IsValid;
                                metadata.IsValid = result.IsValid;
                                metadata.Message = result.Message;
                                if (!result.IsValid)
                                {
                                    itemGrabacionCobranzas.ErrorMessage = result.Message;
                                    itemGrabacionCobranzas.ObjectSend = json;
                                    await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                                }
                            }
                            else
                            {

                                bool cobradoEsTotal = await _cobGrabacionCobranzasService.MontoCobradoEsTotal((long)id);

                                if (cobradoEsTotal)
                                {

                                    Metadata result = await _sapClient.Post("CobranzasTotales", tokenSap, data);
                                    //StringContent dataResult = new StringContent(result.Message, Encoding.UTF8, "application/json");
                                    AppService.Core.DTOs.SapCobroResult.Application resultSapCobros = new AppService.Core.DTOs.SapCobroResult.Application();
                                    resultSapCobros = JsonSerializer.Deserialize<AppService.Core.DTOs.SapCobroResult.Application>(result.Message, options);
                                  

                                    enviadoCorrectamente = result.IsValid;
                                    metadata.IsValid = result.IsValid;
                                    metadata.Message = result.Message;
                                    if (!result.IsValid)
                                    {
                                        itemGrabacionCobranzas.ErrorMessage = result.Message;
                                        itemGrabacionCobranzas.ObjectSend = json;
                                        await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                                    }


                                    //ACTUALIZAMOS EL DOCUMENTO SAP EN LA TABLA cobGrabacionCobranza
                                    if (resultSapCobros.d != null)
                                    {
                                        string docgenerado = resultSapCobros.d.DocGenerado;
                                        string ejercicioDocGenerado = resultSapCobros.d.EjercicioDocGenerado;
                                        itemGrabacionCobranzas.DocumentoSap = docgenerado;
                                        itemGrabacionCobranzas.EjercicioDocumentoSap = ejercicioDocGenerado;
                                        await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                                    }

                                 

                                  

                                }
                                else
                                {
                                    Metadata result = await _sapClient.Post("CobranzasParciales", tokenSap, data);

                                    if (result.IsValid)
                                    {
                                        AppService.Core.DTOs.SapCobroResult.Application resultSapCobros = new AppService.Core.DTOs.SapCobroResult.Application();
                                        resultSapCobros = JsonSerializer.Deserialize<AppService.Core.DTOs.SapCobroResult.Application>(result.Message, options);
                                        string docgenerado = resultSapCobros.d.DocGenerado;
                                        string ejercicioDocGenerado = resultSapCobros.d.EjercicioDocGenerado;


                                        //ACTUALIZAMOS EL DOCUMENTO SAP EN LA TABLA cobGrabacionCobranza
                                        itemGrabacionCobranzas.DocumentoSap = docgenerado;
                                        itemGrabacionCobranzas.EjercicioDocumentoSap = ejercicioDocGenerado;
                                        await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);

                                        enviadoCorrectamente = result.IsValid;
                                        metadata.IsValid = result.IsValid;
                                        metadata.Message = result.Message;

                                    }
                                    else
                                    {

                                        enviadoCorrectamente = result.IsValid;
                                        metadata.IsValid = result.IsValid;
                                        metadata.Message = result.Message;

                                        itemGrabacionCobranzas.ErrorMessage = result.Message;
                                        itemGrabacionCobranzas.ObjectSend = json;
                                        await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);
                                    }


                                }
                            }


                        }



                    }

                }
                else
                {


                    List<AppService.Core.DTOs.SapEnviarSoloRetencion.Application> objSapEnviarSoloRetencion = await _generalCobranzaService.GeneraListSapEnviarSoloRetencion(recibo);
                    foreach (Core.DTOs.SapEnviarSoloRetencion.Application item in objSapEnviarSoloRetencion)
                    {

                        enviadoCorrectamente = false;
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            IgnoreNullValues = true,
                            WriteIndented = true,
                            PropertyNameCaseInsensitive = true
                        };



                        long? id = item.d.Id;
                        item.d.Id = null;

                        CobPagosRetenciones itemRet = await _cobPagosRetencionesService.GetById((long)id);
                        if (itemRet.DocumentoSap=="")
                        {
                            CobGrabacionCobranzas itemGrabacionCobranzas = await _cobGrabacionCobranzasService.GetById(itemRet.IdCobranza);

                            string json = JsonSerializer.Serialize(item, options);

                            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                            Metadata result = await _sapClient.Post("Retenciones", tokenSap, data);
                            //StringContent dataResult = new StringContent(result.Message, Encoding.UTF8, "application/json");


                            if (result.IsValid)
                            {
                                AppService.Core.DTOs.SapCobroResult.Application resultSapCobros = new AppService.Core.DTOs.SapCobroResult.Application();
                                resultSapCobros = JsonSerializer.Deserialize<AppService.Core.DTOs.SapCobroResult.Application>(result.Message, options);
                                string docgenerado = resultSapCobros.d.DocGenerado;
                                string ejercicioDocGenerado = resultSapCobros.d.EjercicioDocGenerado;
                                //ACTUALIZAMOS EL DOCUMENTO SAP EN LA TABLA cobPagoRetenciones

                                CobPagosRetenciones ret = await _cobPagosRetencionesService.GetById((long)id);
                                ret.DocumentoSap = docgenerado;
                                ret.EjercicioDocumentoSap = ejercicioDocGenerado;
                                await _cobPagosRetencionesService.Update(ret);

                                enviadoCorrectamente = result.IsValid;
                                metadata.IsValid = result.IsValid;

                                metadata.Message = result.Message;

                            }
                            else
                            {
                                metadata.IsValid = result.IsValid;
                                metadata.Message = result.Message;

                                itemGrabacionCobranzas.ErrorMessage = result.Message;
                                itemGrabacionCobranzas.ObjectSend = json;
                                await _cobGrabacionCobranzasService.Update(itemGrabacionCobranzas);


                            }
                        }
                      


                    }

                }

                bool reciboTienePendienteContabilizar = await _cobGrabacionCobranzasService.ReciboTienePendienteContabilizar(filters.Documento);

                if (reciboTienePendienteContabilizar)
                {
                    enviadoCorrectamente = false;
                    metadata.IsValid = false;
                    metadata.Message = "Cobranzas pendientes de contabilizar";
                }
                else
                {
                    enviadoCorrectamente = true;
                }


                if (!enviadoCorrectamente)
                {

                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }



                /////////////////////////////////////////////////////////////////////

                Metadata geberaPdf = _generalCobranzaService.GeneraPdfRecibo(recibo, "_Aprobado");

                if (geberaPdf.IsValid)
                {

                    if (generalCobranzas.TotalDetalleCobrado != 0)
                    {
                        generalCobranzas.FlagPagoMas = true;
                    }
                    else
                    {
                        generalCobranzas.FlagPagoMas = false;
                    }

                    generalCobranzas.FlagEnviado = true;

                    generalCobranzas.FechaEnviado = DateTime.Now;



                    generalCobranzas.FlagAprobado = true;
                    generalCobranzas.FechaAprobado = DateTime.Now;
                    generalCobranzas.FechaLm = DateTime.Today;
                    generalCobranzas.FechaLmcxC = DateTime.Today;
                    generalCobranzas.UsuarioAprueba = "RR105841";// User.Identity.Name;


                    //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LM COMISIONES) Y LA///////////
                    //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
                    //var fechaTransaccionString = generalCobranzas.FechaTransaccion.ToString("d");
                    // DateTime fechaTransaccion = Convert.ToDateTime(fechaTransaccionString);
                    //if ((DateTime.Today > Sysfile.FechaLm) && fechaTransaccion <= Sysfile.FechaLm)
                    //{
                    //    generalCobranzas.FechaLm = Sysfile.FechaLm;
                    //}
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////


                    //VERIFICAMOS QUE SI LA FECHA DE APROBACION ES POSTERIOR A LA FECHA DE CORTE (LMCxC) Y LA///////////////////
                    //FECHA DEL PAGO ES MENOR O IGUAL A LA FECHA DE CORTE (LM) LE COLOCAMOS LA FECHA LM/////////////////////////
                    if (DateTime.Today > Sysfile.FechaLmcxC)
                    {
                        generalCobranzas.FechaLmcxC = Sysfile.FechaLmcxC;
                        generalCobranzas.FechaLm = Sysfile.FechaLmcxC;

                    }
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    CobGeneralCobranza resultgeneralCobranzas = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);

                    //ADJUNTAMOS EL RC///////////////////////////////
                    Adjunto.Documento = filters.Documento;
                    Adjunto.IdTipoDocumento = 20;
                    Adjunto.NombreArchivo = "RC_" + filters.Documento.ToString() + "_Aprobado" + ".pdf";
                    Adjunto.Archivo = null;
                    Adjunto.IdUsuarioCreacion = "RR105841";// User.Identity.Name;
                    Adjunto.FechaCreacion = DateTime.Now;
                    Adjunto.Ruta = _paginationOptions.FolderDocumentation + "\\";
                    CobAdjuntosCobranza cobranzaAdjunto = await _cobAdjuntosCobranzaService.Insert(Adjunto);

                   


                    metadata.IsValid = true;
                    metadata.Message = "Recibo Aprobado con éxito.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = geberaPdf.IsValid;
                    metadata.Message = geberaPdf.Message;
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }






        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AnularCobranza(GeneralCobranzaQueryFilter filters)
        {


            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();



            if (generalCobranzas != null)
            {

                if (!generalCobranzas.FlagAprobado)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC no esta aprobado.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }



                ///////////////////ANULAR RECIBO A SAP //////////////////////////////



                bool enviadoCorrectamente = false;

                string userSap = _paginationOptions.UserSap;
                string passwordSap = _paginationOptions.PasswordSap;
                string tokenSap = "";
                Metadata meta = await _sapClient.GetToken(userSap, passwordSap);
                if (meta.IsValid)
                {
                    tokenSap = meta.Message;

                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Conexion Invalida...Intente mas tarde";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


                enviadoCorrectamente = false;
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                };

                Recibo objRecibo = new Recibo
                {
                    NroRecibo = generalCobranzas.Documento
                };

                string json = JsonSerializer.Serialize(objRecibo, options);

                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");
                string action = $"AnularReciboCobro?NroRecibo={generalCobranzas.Documento}";

                Metadata result = await _sapClient.Post(action, tokenSap, data);
                //StringContent dataResult = new StringContent(result.Message, Encoding.UTF8, "application/json");
                //D resultSapCobros = new D();
                //resultSapCobros = JsonSerializer.Deserialize<D>(result.Message, options);

                //string docgenerado = resultSapCobros.DocGenerado;
                //string ejercicioDocGenerado = resultSapCobros.EjercicioDocGenerado;



                enviadoCorrectamente = result.IsValid;



                if (!enviadoCorrectamente)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Error al enviar Documento a Sap. Reintente mas tarde";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    generalCobranzas.FlagAnulado = true;

                    generalCobranzas.FechaAnulado = DateTime.Now;

                    generalCobranzas.FlagReversado = true;

                    generalCobranzas.FechaReversado = DateTime.Now;

                    generalCobranzas.UsuarioAnula = "RR105841";//  User.Identity.Name;
                    CobGeneralCobranza resultgeneralCobranzas = await _generalCobranzaService.UpdateGeneralCobranza(generalCobranzas);

                    metadata.IsValid = true;
                    metadata.Message = "Recibo Anulado con éxito.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }






        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GeneraRecibo(GeneralCobranzaQueryFilter filters)
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };



            CobGeneralCobranza generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(filters.Documento);
            CobGeneralCobranzaDto generalCobranzasDtos = new CobGeneralCobranzaDto();
            CobAdjuntosCobranza Adjunto = new CobAdjuntosCobranza();
            CobAdjuntosCobranza AdjuntoJpg = new CobAdjuntosCobranza();
            if (generalCobranzas != null)
            {


                bool reciboTieneCobro = _cobGrabacionCobranzasService.ReciboTieneCobro(filters.Documento);
                if (reciboTieneCobro == false)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC aun no tiene cobranza y / o retenciones grabada.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };



                    return Ok(response);
                }

                bool GrabacionCobranzasTieneRetencionCero = await _cobGrabacionCobranzasService.GrabacionCobranzasTieneRetencionCero(filters.Documento);


                if (GrabacionCobranzasTieneRetencionCero)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Este RC tiene monto cero en su detalle.";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


                ReciboDto recibo = await _generalCobranzaService.GeneraReciboDto(filters.Documento);
                Metadata geberaPdf = _generalCobranzaService.GeneraPdfRecibo(recibo, "_Consultado");
                if (geberaPdf.IsValid)
                {





                    //ADJUNTAMOS EL RC///////////////////////////////
                    Adjunto.Documento = filters.Documento;
                    Adjunto.IdTipoDocumento = 20;
                    Adjunto.NombreArchivo = "RC_" + filters.Documento.ToString() + "_Consultado" + ".pdf";
                    Adjunto.Archivo = null;
                    Adjunto.IdUsuarioCreacion = "RR105841";// User.Identity.Name;
                    Adjunto.FechaCreacion = DateTime.Now;
                    Adjunto.Ruta = _paginationOptions.FolderDocumentation + "\\";
                    CobAdjuntosCobranza cobranzaAdjunto = await _cobAdjuntosCobranzaService.Insert(Adjunto);


                    metadata.IsValid = true;
                    metadata.Message = "Documento generado..Consultelo en Adjunto como: " + "RC_" + filters.Documento.ToString() + "_Consultado" + ".pdf";
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = geberaPdf.IsValid;
                    metadata.Message = geberaPdf.Message;
                    ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }


            }
            else
            {
                metadata.IsValid = false;
                metadata.Message = "Documento no encontrado";
                ApiResponse<CobGeneralCobranzaDto> response = new ApiResponse<CobGeneralCobranzaDto>(generalCobranzasDtos)
                {
                    Meta = metadata
                };

                return Ok(response);
            }


        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateSearchText()
        {
            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = ""
            };

            await _generalCobranzaService.UpdateSearchText();

            metadata.IsValid = true;

            metadata.Message = "Actualizado satisfactoriamente";

            return Ok(metadata);

        }



    }
}