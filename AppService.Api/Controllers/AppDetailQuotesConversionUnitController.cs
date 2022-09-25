using AppService.Api.Responses;
using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
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
    public class AppDetailQuotesConversionUnitController : ControllerBase
    {
        private readonly IAppDetailQuotesConversionUnitService _appDetailQuotesConversionUnitService;

        public AppDetailQuotesConversionUnitController(IAppDetailQuotesConversionUnitService appDetailQuotesConversionUnitService)
        {
            _appDetailQuotesConversionUnitService = appDetailQuotesConversionUnitService;
        }


        /// <summary>
        /// Calcula receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="appDetailQuotesConversionUnitCreateDto">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateAppDetailQuotesConversionUnit(AppDetailQuotesConversionUnitCreateDto appDetailQuotesConversionUnitCreateDto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                //var detailQuotesConversionUnit = await _appDetailQuotesConversionUnitService.CreateAppDetailQuotesConversionUnit(appDetailQuotesConversionUnitCreateDto);



                //return Ok(detailQuotesConversionUnit);
                var detailQuotesConversionUnit = await _appDetailQuotesConversionUnitService.CreateAppDetailQuotesConversionUnit(appDetailQuotesConversionUnitCreateDto);
                return Ok(detailQuotesConversionUnit);


                //if (appDetailQuotesConversionUnitCreateDto.AppDetailQuotesId >0)
                //{
                //    var detailQuotesConversionUnit = await _appDetailQuotesConversionUnitService.CreateAppDetailQuotesConversionUnit(appDetailQuotesConversionUnitCreateDto);
                //    return Ok(detailQuotesConversionUnit);
                //}
                //else
                //{
                //    AppConversionUnitGenericCreateDto dto = new AppConversionUnitGenericCreateDto();

                //    dto.AppProductId = appDetailQuotesConversionUnitCreateDto.AppProductId;
                //    dto.AppUnitIdSince = appDetailQuotesConversionUnitCreateDto.AppUnitIdSince;
                //    dto.AppUnitIdUntil = appDetailQuotesConversionUnitCreateDto.AppUnitIdUntil;
                //    List<AppTemplateConversionGenericUnitGetDto> newList = new List<AppTemplateConversionGenericUnitGetDto>();
                //    if (appDetailQuotesConversionUnitCreateDto.AppTemplateConversionUnitGetDto != null)
                //    {


                //        foreach (var item in appDetailQuotesConversionUnitCreateDto.AppTemplateConversionUnitGetDto)
                //        {
                //            AppTemplateConversionGenericUnitGetDto newItem = new AppTemplateConversionGenericUnitGetDto();
                //            newItem.AppVariableId = item.AppVariableId;
                //            newItem.Description = item.Description;
                //            newItem.Value = item.Value;
                //            newList.Add(newItem);

                //        }
                //        dto.AppTemplateConversionGenericUnitGetDto = newList;
                //    }


                //    var detailQuotesConversionUnit = await _appDetailQuotesConversionUnitService.ConversionUnitGeneric(dto);
                //    return Ok(detailQuotesConversionUnit);
                //}



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppDetailQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }

        /// <summary>
        /// Calcula receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> ConversionUnitGeneric(AppConversionUnitGenericCreateDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var detailQuotesConversionUnit = await _appDetailQuotesConversionUnitService.ConversionUnitGeneric(dto);



                return Ok(detailQuotesConversionUnit);



            }
            catch (Exception e)
            {

                metadata.IsValid = false;
                metadata.Message = e.InnerException.Message;
                var responseError = new ApiResponse<AppDetailQuotesGetDto>(null)
                {
                    Meta = metadata
                };


                return Ok(responseError);
            }


        }





    }
}