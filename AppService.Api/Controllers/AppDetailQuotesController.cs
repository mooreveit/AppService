using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
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
    public class AppDetailQuotesController : ControllerBase
    {
        private readonly IAppDetailQuotesService _appDetailQuotesService;
        private readonly IAppGeneralQuotesService _appGeneralQuotesService;
        private readonly ICotizacionService _cotizacionService;

        public AppDetailQuotesController(IAppDetailQuotesService appDetailQuotesService,
                                           IAppGeneralQuotesService appGeneralQuotesService,
                                           ICotizacionService cotizacionService)
        {
            _appDetailQuotesService = appDetailQuotesService;
            _appGeneralQuotesService = appGeneralQuotesService;
            _cotizacionService = cotizacionService;
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
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppDetailQuotesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> InsertDetailQuotes(AppDetailQuotesCreateDto appDetailQuotesCreateDto)
        {



            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                Core.Responses.ApiResponse<AppDetailQuotesGetDto> detailQuotes = await _appDetailQuotesService.InsertAppDetailQuotes(appDetailQuotesCreateDto);

                if (detailQuotes.Meta.IsValid)
                {
                    AppGeneralQuotesQueryFilter filterGeneral = new AppGeneralQuotesQueryFilter
                    {
                        Cotizacion = detailQuotes.Data.Cotizacion
                    };
                    PagedList<AppGeneralQuotesGetDto> generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filterGeneral);
                    foreach (AppGeneralQuotesGetDto item in generalQuotes)
                    {
                        item.AppDetailQuotesInsertedGetDto = detailQuotes.Data;
                    }


                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = detailQuotes.Meta
                    };
                    return Ok(response);

                }

                return Ok(detailQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                ApiResponse<AppDetailQuotesGetDto> responseError = new ApiResponse<AppDetailQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }



        /// <summary>
        /// Crea y Retorna los datos de AppDetailQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="appDetailQuotesUpdateDto"></param>
        /// <param name="filters">Filtros a aplicar AppDetailQuotesQueryFilter, si en el objeto incluye Cotizacion, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppDetailQuotesGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateDetailQuotes(AppDetailQuotesUpdateDto appDetailQuotesUpdateDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var appDetailQuotes = await _appDetailQuotesService.GetById(appDetailQuotesUpdateDto.Id);
                if (appDetailQuotes != null)
                {
                    // SI CAMBIA EL PRODUCTO DEL ITEM SE PROCEDE A ELIMININAR  Y CREAR CON EL NUEVO PRODUCTO
                    if (appDetailQuotes.IdProducto != appDetailQuotesUpdateDto.IdProducto)
                    {
                        AppDetailQuotesDeleteDto appDetailQuotesDeleteDto = new AppDetailQuotesDeleteDto();
                        appDetailQuotesDeleteDto.Id = appDetailQuotesUpdateDto.Id;
                        appDetailQuotesDeleteDto.Cotizacion = appDetailQuotes.Cotizacion;
                        var detailQuotesDeleted = await _appDetailQuotesService.DeleteDetailQuotes(appDetailQuotesDeleteDto);


                        var appDetailQuotesCreateDto = MapUpdataDtoToCreateDto(appDetailQuotesUpdateDto, appDetailQuotes.AppGeneralQuotesId, appDetailQuotes.Cotizacion);
                        var detailQuotesInserted = await _appDetailQuotesService.InsertAppDetailQuotes(appDetailQuotesCreateDto);
                        if (detailQuotesInserted.Meta.IsValid)
                        {
                            AppGeneralQuotesQueryFilter filterGeneral = new AppGeneralQuotesQueryFilter
                            {
                                Cotizacion = detailQuotesInserted.Data.Cotizacion
                            };
                            PagedList<AppGeneralQuotesGetDto> generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filterGeneral);
                            foreach (AppGeneralQuotesGetDto item in generalQuotes)
                            {
                                item.AppDetailQuotesInsertedGetDto = detailQuotesInserted.Data;
                            }


                            ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                            {
                                Meta = detailQuotesInserted.Meta
                            };
                            return Ok(response);

                        }


                    }
                }

                Core.Responses.ApiResponse<AppDetailQuotesGetDto> detailQuotes = await _appDetailQuotesService.UpdateAppDetailQuotes(appDetailQuotesUpdateDto);

                if (detailQuotes.Meta.IsValid)
                {
                    AppGeneralQuotesQueryFilter filterGeneral = new AppGeneralQuotesQueryFilter
                    {
                        Cotizacion = detailQuotes.Data.Cotizacion
                    };
                    PagedList<AppGeneralQuotesGetDto> generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filterGeneral);
                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = detailQuotes.Meta
                    };
                    return Ok(response);

                }
                return Ok(detailQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                ApiResponse<AppDetailQuotesGetDto> responseError = new ApiResponse<AppDetailQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        /// <summary>
        /// Elimina AppDetailQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteDetailQuotes(AppDetailQuotesDeleteDto appDetailQuotesDeleteDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                Core.Responses.ApiResponse<bool> detailQuotes = await _appDetailQuotesService.DeleteDetailQuotes(appDetailQuotesDeleteDto);
                if (detailQuotes.Meta.IsValid)
                {
                    AppGeneralQuotesQueryFilter filterGeneral = new AppGeneralQuotesQueryFilter
                    {
                        Cotizacion = appDetailQuotesDeleteDto.Cotizacion
                    };
                    PagedList<AppGeneralQuotesGetDto> generalQuotes = await _appGeneralQuotesService.GetAllAppGeneralQuotes(filterGeneral);
                    ApiResponse<List<AppGeneralQuotesGetDto>> response = new ApiResponse<List<AppGeneralQuotesGetDto>>(generalQuotes)
                    {
                        Meta = detailQuotes.Meta
                    };
                    return Ok(response);

                }
                return Ok(detailQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                ApiResponse<AppGeneralQuotesGetDto> responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }
        /// <summary>
        /// GanarPerder en  AppDetailQuotes
        ///  
        /// 
        /// </summary>
        /// <param name="filters">N/A</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GanarPerder(AppGanarPerderDto appGanarPerderDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                Core.Responses.ApiResponse<bool> detailQuotes = await _appDetailQuotesService.GanarPerder(appGanarPerderDto);


                return Ok(detailQuotes);


            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                ApiResponse<bool> responseError = new ApiResponse<bool>(false)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }





        /// <summary>
        /// Lista AppDetailQuotes por Id de Cotizacion General
        ///  
        /// 
        /// </summary>
        /// <param name="filters">AppDetailQuotesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetListAppDetailQuoteByAppGeneralQuotesId(AppDetailQuotesQueryFilter filter)
        {



            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                Core.Responses.ApiResponse<List<AppDetailQuotesGetDto>> detailQuotes = await _appDetailQuotesService.GetListAppDetailQuoteByAppGeneralQuotesId(filter.AppGeneralQuotesId);
                return Ok(detailQuotes);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                ApiResponse<AppGeneralQuotesGetDto> responseError = new ApiResponse<AppGeneralQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }


        public AppDetailQuotesCreateDto MapUpdataDtoToCreateDto(AppDetailQuotesUpdateDto dto, int appGeneralQuotedId, string cotizacion)
        {




            AppDetailQuotesCreateDto appDetailQuotesCreateDto = new AppDetailQuotesCreateDto();
            appDetailQuotesCreateDto.AppGeneralQuotesId = appGeneralQuotedId;

            appDetailQuotesCreateDto.Cotizacion = cotizacion;
            appDetailQuotesCreateDto.IdProducto = dto.IdProducto;
            appDetailQuotesCreateDto.NombreComercialProducto = dto.NombreComercialProducto;
            appDetailQuotesCreateDto.IdEstatus = dto.IdEstatus;
            appDetailQuotesCreateDto.Cantidad = dto.Cantidad;
            appDetailQuotesCreateDto.CantidadSolicitada = dto.CantidadSolicitada;
            appDetailQuotesCreateDto.Precio = dto.Precio;
            appDetailQuotesCreateDto.Total = dto.Total;
            appDetailQuotesCreateDto.PrecioUsd = dto.PrecioUsd;
            appDetailQuotesCreateDto.TotalUsd = dto.TotalUsd;
            appDetailQuotesCreateDto.IdUnidad = dto.IdUnidad;
            appDetailQuotesCreateDto.Observaciones = dto.Observaciones;
            appDetailQuotesCreateDto.DiasEntrega = dto.DiasEntrega;
            appDetailQuotesCreateDto.PrecioLista = dto.PrecioLista;
            appDetailQuotesCreateDto.SolicitarPrecio = dto.SolicitarPrecio;
            appDetailQuotesCreateDto.ObsSolicitud = dto.ObsSolicitud;
            if (dto.ValorConvertido == null) dto.ValorConvertido = 0;
            appDetailQuotesCreateDto.ValorConvertido = (decimal)dto.ValorConvertido;
            if (dto.UnitPriceBaseProduction == null) dto.UnitPriceBaseProduction = 0;
            appDetailQuotesCreateDto.UnitPriceBaseProduction = (decimal)dto.UnitPriceBaseProduction;
            if (dto.UnitPriceConverted == null) dto.UnitPriceConverted = 0;
            appDetailQuotesCreateDto.UnitPriceConverted = (decimal)dto.UnitPriceConverted;
            if (dto.CantidadPorUnidadProduccion == null) dto.CantidadPorUnidadProduccion = 0;
            appDetailQuotesCreateDto.CantidadPorUnidadProduccion = (decimal)dto.CantidadPorUnidadProduccion;
            appDetailQuotesCreateDto.QuantityPerPackage = dto.QuantityPerPackage;
            appDetailQuotesCreateDto.OrdenAnterior = dto.OrdenAnterior;
            appDetailQuotesCreateDto.MedidaBasica = dto.MedidaBasica;
            appDetailQuotesCreateDto.MedidaOpuesta = dto.MedidaOpuesta;

            return appDetailQuotesCreateDto;
        }
    }
}