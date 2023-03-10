using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //Comentario  para ver si en el git status lo refleja como modificado. 1707

    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("charppolicy")]
    public class CobAdjuntosCobranzaController : ControllerBase
    {
        private readonly ICobAdjuntosCobranzaService _cobAdjuntosCobranzaService;
        private readonly IGeneralCobranzaService _generalCobranzaService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IOfdTipoDocumentoService _ofdTipoDocumentoService;
        private readonly ILogger<CobAdjuntosCobranzaController> _logger;
        private readonly IAppProductsService _appProductsService;
        private readonly PaginationOptions _paginationOptions;

        //Constructor
        public CobAdjuntosCobranzaController(ICobAdjuntosCobranzaService cobAdjuntosCobranzaService,
                                             IGeneralCobranzaService generalCobranzaService,
                                            IMapper mapper,
                                            IUriService uriService,
                                            IOptions<PaginationOptions> options,
                                            IOfdTipoDocumentoService ofdTipoDocumentoService,
                                            ILogger<CobAdjuntosCobranzaController> logger,
                                            IAppProductsService appProductsService)
        {
            _cobAdjuntosCobranzaService = cobAdjuntosCobranzaService;
            _generalCobranzaService = generalCobranzaService;
            _mapper = mapper;
            _uriService = uriService;
            _ofdTipoDocumentoService = ofdTipoDocumentoService;
            _logger = logger;
            _appProductsService = appProductsService;
            _paginationOptions = options.Value;
        }

        /// <summary>
        /// Retorna los datos de adjuntos cobranza
        /// </summary>
        /// <param name="filters">Filtros a aplicar AdjuntosCobranzaFilter</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetCobAdjuntosCobranza([FromQuery] AdjuntosCobranzaFilter filters)
        {
            var usuario = "rr105841";//User.Identity.Name;
            await _generalCobranzaService.GeneraRecibo((long)filters.Documento, usuario);
            PagedList<CobAdjuntosCobranza> cobranzaAdjuntos = await _cobAdjuntosCobranzaService.GetCobAdjuntosCobranza(filters);

            IEnumerable<CobAdjuntosCobranzaDto> adjuntosCobranzaDto = _mapper.Map<IEnumerable<CobAdjuntosCobranzaDto>>(cobranzaAdjuntos);

            List<CobAdjuntosCobranzaDto> result = new List<CobAdjuntosCobranzaDto>();
            foreach (var item in adjuntosCobranzaDto)
            {
                var tipoDocumento = await _ofdTipoDocumentoService.GetById(item.IdTipoDocumento);
                item.DescripcionTipoDocumento = tipoDocumento.NombreDocumento;
                result.Add(item);
            }

            Metadata metadata = new Metadata
            {
                TotalCount = cobranzaAdjuntos.TotalCount,
                PageSize = cobranzaAdjuntos.PageSize,
                CurrentPage = cobranzaAdjuntos.CurrentPage,
                TotalPage = cobranzaAdjuntos.TotalPage,
                HasNextPage = cobranzaAdjuntos.HasNextPage,
                HasPreviousPage = cobranzaAdjuntos.HasPreviousPage,
                NextPageUrl = "",  // _uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
                PreviousPageUrl = ""  //_uriService.GetGeneralCobranzaPaginationUri(filters, "api/GeneralCobranzas").ToString(),
            };

            //ApiResponse<IEnumerable<CobGeneralCobranzaDto>> response = new ApiResponse<IEnumerable<CobGeneralCobranzaDto>>(generalCobranzasDtos);
            var response = new ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>(result)
            {
                Meta = metadata
            };

            return Ok(response);
        }

        //
        /// <summary>
        /// Retorna los datos de adjuntos cobranza
        /// Filtros a aplicar AdjuntosCobranzaFilter, si en el objeto incluye documento, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AdjuntosCobranzaFilter, si en el objeto incluye documento, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAdjuntosCobranza(AdjuntosCobranzaFilter filters)
        {

            // await ReconstruyeTiffAPng();

            List<CobAdjuntosCobranzaDto> result = new List<CobAdjuntosCobranzaDto>();

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };

            _logger.LogWarning("Iniciando Get all Adjubtos del Documento:" + filters.Documento.ToString());

            try
            {

                var generalCobranza = await _generalCobranzaService.GetGeneralCobranzaPorDocumento((long)filters.Documento);

                if (generalCobranza.FlagAprobado == false)
                {
                    var usuario = "RR105841";// User.Identity.Name;
                    await _generalCobranzaService.GeneraRecibo((long)filters.Documento, usuario);
                }


                PagedList<CobAdjuntosCobranza> listaAdjuntos;

                listaAdjuntos = await _cobAdjuntosCobranzaService.GetCobAdjuntosCobranza(filters);


                IEnumerable<CobAdjuntosCobranzaDto> adjuntosCobranzaDto = _mapper.Map<IEnumerable<CobAdjuntosCobranzaDto>>(listaAdjuntos);



                foreach (var item in adjuntosCobranzaDto)
                {
                    var tipoDocumento = await _ofdTipoDocumentoService.GetById(item.IdTipoDocumento);
                    item.DescripcionTipoDocumento = tipoDocumento.NombreDocumento;
                    item.Link = _paginationOptions.UrlGetFiles + item.NombreArchivo;
                    var extencion = Path.GetExtension(item.NombreArchivo);

                    if (extencion.ToLower() == ".pdf")
                    {
                        item.IsImage = false;
                    }
                    else
                    {
                        item.IsImage = true;
                    }
                    result.Add(item);
                }


                metadata.IsValid = true;
                metadata.Message = "";
                metadata.TotalCount = listaAdjuntos.TotalCount;
                metadata.PageSize = listaAdjuntos.PageSize;
                metadata.CurrentPage = listaAdjuntos.CurrentPage;
                metadata.TotalPage = listaAdjuntos.TotalPage;
                metadata.HasNextPage = listaAdjuntos.HasNextPage;
                metadata.HasPreviousPage = listaAdjuntos.HasPreviousPage;
                metadata.NextPageUrl = "";
                metadata.PreviousPageUrl = "";

                _logger.LogWarning("Lista de Adjuntos recuperada corectamente del Documento:" + filters.Documento.ToString());


            }
            catch (Exception e)
            {
  
                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>(result)
                {
                    Meta = metadata
                };

             
                return Ok(responseError);
            }

            result = result.OrderByDescending(x => x.FechaCreacion).ToList();
            var response = new ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>(result)
            {
                Meta = metadata
            };

            _logger.LogWarning("Return  Get all Adjuntos del Documento:" + filters.Documento.ToString());
            return Ok(response);
        }


        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //public async Task<IActionResult> PostImage(IFormFile image)
        public async Task<IActionResult> PostImage(List<CobAdjuntosCobranzaDto> vmList)
        {
            int contadorImagenesProcesadas = 0;

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };

            try
            {



                foreach (CobAdjuntosCobranzaDto vm in vmList)
                {
                    //Viene establecido
                    //vm.Documento;           

                    //Viene establecido
                    //vm.IdTipoDocumento

                    var generalCobranzas = await _generalCobranzaService.GetGeneralCobranzaPorDocumento(vm.Documento);
                    if (generalCobranzas == null)
                    {
                        vm.Valid = false;
                        _logger.LogWarning("PostImage - Error al insertar regitro en tabla del Documento, no existe ne CobGeneralCobranzas:" + vm.Documento);
                    }
                    else
                    {
                        _logger.LogWarning("PostImage - Iniciando Adjuntos del Documento:" + vm.Documento);

                        vm.NombreArchivo = $@"{DateTime.Now.Ticks}" + vm.Extension;

                        vm.IdUsuarioCreacion = vm.IdUsuarioCreacion;

                        vm.FechaCreacion = DateTime.Now;

                        vm.Ruta = _paginationOptions.FolderDocumentation + "\\";
                        //

                        //CREA EL ARCHIVO DE IMAGEN

                        //Convert Base64 Encoded string to Byte Array.
                        string base64 = vm.Data;
                        byte[] imageBytes = Convert.FromBase64String(base64);

                        //Ruta y nombre de la imagen
                        var imageFullName = vm.Ruta + vm.NombreArchivo;

                        _logger.LogWarning("PostImage - Creando archivo Adjuntos del Documento:" + vm.Documento);
                        //creo el fichero
                        await System.IO.File.WriteAllBytesAsync(imageFullName, imageBytes);
                        _logger.LogWarning("PostImage - Archivo Creado Adjuntos del Documento:" + vm.Documento);




                        //vm.Data = null;

                        //

                        //INSERT en la tabla CobAdjuntosCobranza (datos en el objeto vm )
                        CobAdjuntosCobranza cobAdjuntosCobranza = _mapper.Map<CobAdjuntosCobranza>(vm);
                        var cobranza = await _cobAdjuntosCobranzaService.Insert(cobAdjuntosCobranza);

                        if (cobranza == null)
                        {
                            //Error al insertar
                            vm.Valid = false;
                            _logger.LogWarning("PostImage - Error al insertar regitro en tabla del Documento:" + vm.Documento);
                        }
                        else
                        {
                            //insert valido
                            vm.Valid = true;
                            _logger.LogWarning("PostImage regitro insertado en tabla del Documento:" + vm.Documento);
                        }

                        contadorImagenesProcesadas += 1;
                    }


                }

                metadata.IsValid = true;
                metadata.Message = "Imágenes grabadas correctamente.";
                metadata.TotalCount = contadorImagenesProcesadas;

            }
            catch (Exception e)
            {
                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                _logger.LogError("PostImage - Error  del Documento:" + e.InnerException.Message);

                metadata.TotalCount = 0;
            }

            //devuelve en la lista solo los no validos
            vmList = vmList.Where(x => !x.Valid).ToList();

            var response = new ApiResponse<List<CobAdjuntosCobranzaDto>>(vmList)
            {
                Meta = metadata
            };

            return Ok(response);

        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostImagebk(IFormFile image)
        {


            var filepath = Path.GetTempFileName();
            filepath = _paginationOptions.FolderDocumentation;
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }



            return Ok();
        }



        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ApiResponse<AppProductsGetDto>> UpdateImageAppProduct(AppproductImageDto dto)
        {

            AppProductsGetDto resultDto = new AppProductsGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppProductsGetDto> response = new ApiResponse<AppProductsGetDto>(resultDto);
            var product = await _appProductsService.GetById(dto.Id);
            if (product == null)
            {
                metadata.IsValid = false;
                metadata.Message = "Codigo de producto no existe, verifique por favor";
                response.Meta = metadata;
                response.Data = resultDto;
                return response;
            }


            var NombreArchivo = $@"Producto_{product.Code}_{DateTime.Now.Ticks}" + ".png";

            var FechaCreacion = DateTime.Now;

            var Ruta = _paginationOptions.FolderDocumentation + "\\";
            //

            //CREA EL ARCHIVO DE IMAGEN

            //Convert Base64 Encoded string to Byte Array.
            string base64 = dto.Data;
            byte[] imageBytes = Convert.FromBase64String(base64);

            //Ruta y nombre de la imagen
            var imageFullName = Ruta + NombreArchivo;


            //creo el fichero
            await System.IO.File.WriteAllBytesAsync(imageFullName, imageBytes);

            product.UrlImage = NombreArchivo;
            var productUpdated = await _appProductsService.Update(product);
            var result = await _appProductsService.GetProduct(product.Id);
            resultDto = result.Data;

            metadata.IsValid = true;
            metadata.Message = "Imagen de producto Actualizada";
            response.Meta = metadata;
            response.Data = resultDto;
            return response;

        }


        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<CobAdjuntosCobranzaDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task ReconstruyeTiffAPng()
        {

            var folder = _paginationOptions.FolderDocumentation + "\\";

            var cobranza = await _cobAdjuntosCobranzaService.GetCobAdjuntosCTiff();
            foreach (var item in cobranza)
            {
                var nombreArr = item.NombreArchivo.Split('.');
                var nombre = nombreArr[0];

                System.Drawing.
                     Bitmap.FromFile(folder + item.NombreArchivo)
                     .Save(folder + nombre + ".png", System.Drawing.Imaging.ImageFormat.Png);


                CobAdjuntosCobranza cobAdjuntosCobranzaNew = new CobAdjuntosCobranza();
                cobAdjuntosCobranzaNew.FechaCreacion = item.FechaCreacion;
                cobAdjuntosCobranzaNew.Documento = item.Documento;
                cobAdjuntosCobranzaNew.IdTipoDocumento = item.IdTipoDocumento;
                cobAdjuntosCobranzaNew.Ruta = item.Ruta;
                cobAdjuntosCobranzaNew.IdUsuarioCreacion = item.IdUsuarioCreacion;
                cobAdjuntosCobranzaNew.NombreArchivo = nombre + ".png";

                await _cobAdjuntosCobranzaService.Insert(cobAdjuntosCobranzaNew);

                await _cobAdjuntosCobranzaService.DeleteByNameFile(item.Documento, item.NombreArchivo);








            }


        }
    }

}