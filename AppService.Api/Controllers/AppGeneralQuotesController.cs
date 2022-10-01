using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.DTOs.Odoo.Cotizaciones.Recibir;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
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
    public class AppGeneralQuotesController : ControllerBase
    {
        private readonly IAppGeneralQuotesService _appGeneralQuotesService;
        private readonly ICotizacionService _cotizacionService;

        public AppGeneralQuotesController(IAppGeneralQuotesService appGeneralQuotesService,
                                           ICotizacionService cotizacionService)
        {
            _appGeneralQuotesService = appGeneralQuotesService;
            _cotizacionService = cotizacionService;
        }





        /// <summary>
        /// Copia y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateCotizacionesToOdoo()
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {



                // var cotizacionesActualizar = await _appGeneralQuotesService.GetListCotizaciones();

                // var lista = cotizacionesActualizar.Where(x => x == "LN01202209008").ToList();


                await _cotizacionService.UpdateCotizacionesToOdoo();

                metadata.IsValid = true;
                metadata.Message = "Actualizado correctamente";
                var response = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };
                return Ok(response);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }
        }


        /// <summary>
        /// Copia y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> IntegrarCotizacionesPorMes()
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {

                await _cotizacionService.IntegrarCotizacionesPorMes();



                return Ok();



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }
        }





        /// <summary>
        /// Retorna los datos de AppGeneralQuotes
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                //_cotizacionService.IntegrarCotizaciones();

                // await _cotizacionService.IntegrarCotizacion(667, true);



                var generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filters);



                if (generalQuotes != null)
                {
                    metadata.IsValid = true;
                    metadata.Message = "";
                    metadata.TotalCount = generalQuotes.TotalCount;
                    metadata.PageSize = generalQuotes.PageSize;
                    metadata.CurrentPage = generalQuotes.CurrentPage;
                    metadata.TotalPage = generalQuotes.TotalPage;
                    metadata.HasNextPage = generalQuotes.HasNextPage;
                    metadata.HasPreviousPage = generalQuotes.HasPreviousPage;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = true;
                    metadata.Message = "No Data.......";
                    metadata.TotalCount = 0;
                    metadata.PageSize = filters.PageSize;
                    metadata.CurrentPage = 0;
                    metadata.TotalPage = filters.PageNumber;
                    metadata.HasNextPage = false;
                    metadata.HasPreviousPage = false;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
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


        /// <summary>
        /// Retorna los datos de AppGeneralQuotes
        /// Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllSimpleAppGeneralQuotes(AppGeneralQuotesQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.GetAllSimpleAppGeneralQuotes(filters);

                if (generalQuotes != null)
                {
                    metadata.IsValid = true;
                    metadata.Message = "";
                    metadata.TotalCount = generalQuotes.TotalCount;
                    metadata.PageSize = generalQuotes.PageSize;
                    metadata.CurrentPage = generalQuotes.CurrentPage;
                    metadata.TotalPage = generalQuotes.TotalPage;
                    metadata.HasNextPage = generalQuotes.HasNextPage;
                    metadata.HasPreviousPage = generalQuotes.HasPreviousPage;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = metadata
                    };

                    return Ok(response);
                }
                else
                {
                    metadata.IsValid = true;
                    metadata.Message = "No Data.......";
                    metadata.TotalCount = 0;
                    metadata.PageSize = filters.PageSize;
                    metadata.CurrentPage = 0;
                    metadata.TotalPage = filters.PageNumber;
                    metadata.HasNextPage = false;
                    metadata.HasPreviousPage = false;
                    metadata.NextPageUrl = "";
                    metadata.PreviousPageUrl = "";

                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
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

        /// <summary>
        /// Crea y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> InsertGeneralQuotes(AppGeneralQuotesCreateDto appGeneralQuotesCreateDto)
        {



            AppGeneralQuotesGetDto resultDto = new AppGeneralQuotesGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<AppGeneralQuotesGetDto> response = new ApiResponse<AppGeneralQuotesGetDto>(resultDto);



            try
            {


                var generalQuotes = await _appGeneralQuotesService.InsertGeneralQuotes(appGeneralQuotesCreateDto);

                AppGeneralQuotesQueryFilter filters = new AppGeneralQuotesQueryFilter
                {
                    Cotizacion = generalQuotes.Data.Cotizacion,
                    SearchText = "",
                    PageNumber = 1,
                    PageSize = 100,
                    UsuarioConectado = generalQuotes.Data.UsuarioActualiza
                };

                var generalQuotesNew = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filters);


                generalQuotes.Data = generalQuotesNew[0];
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }
        /// <summary>
        /// Copia y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesCopyDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CopiarGeneralQuotes(AppGeneralQuotesCopyDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.CopiarGeneralQuotes(dto);

                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }




        /// <summary>
        /// Actualiza y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateGeneralQuotes(AppGeneralQuotesUpdateDto appGeneralQuotesUpdateDto)
        {



            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.UpdateGeneralQuotes(appGeneralQuotesUpdateDto);

                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }



        /// <summary>
        /// Elimina AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteGeneralQuotes(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.DeleteGeneralQuotes(appGeneralQuotesDeleteDto);
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        /// <summary>
        /// Enviar al Cliente
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppGeneralQuotesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> EnviarAlCliente(AppGeneralQuotesChangeStatusDto dto)
        {


            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.EnviarAlCliente(dto);
                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }




        /// <summary>
        /// Elimina AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> IntegraCotizacion(AppGeneralQuotesDeleteDto appGeneralQuotesDeleteDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                await _cotizacionService.IntegrarCotizacion(appGeneralQuotesDeleteDto.Id, true);
                return Ok();



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        /// <summary>
        /// Copia y Retorna los datos de AppGeneralQuotes
        /// 
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppGeneralQuotesCopyDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(ApiResponse<List<AppGeneralQuotesGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> RegresarAGrabacionCotizacion(
          AppGeneralQuotesCopyDto dto)
        {
            AppGeneralQuotesController quotesController = this;
            Metadata metadata = new Metadata()
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };
            try
            {
                var apiResponse = await _appGeneralQuotesService.RegresarAGrabacionCotizacion(dto);
                return (IActionResult)quotesController.Ok((object)apiResponse);
            }
            catch (Exception ex)
            {
                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                ApiResponse<AppGeneralQuotesGetDto> apiResponse = new ApiResponse<AppGeneralQuotesGetDto>((AppGeneralQuotesGetDto)null)
                {
                    Meta = metadata
                };
                return (IActionResult)quotesController.Ok((object)apiResponse);
            }
        }



        //######################################################################################
        //#################### CONTROLLERS ODOO ################################################
        //######################################################################################
        /// <summary>
        /// Actualiza y Retorna los datos de AppGeneralQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Crea y Actualiza AppGeneralQuotes desde Odoo</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<GeneralGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateGeneral(GeneralUpdateDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var generalQuotes = await _appGeneralQuotesService.OdooGeneralUpdate(dto);

                return Ok(generalQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }






    }
}