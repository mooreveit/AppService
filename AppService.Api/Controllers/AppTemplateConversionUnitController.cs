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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppTemplateConversionUnitController : ControllerBase
    {
        private readonly IAppTemplateConversionUnitService _appTemplateConversionUnitService;

        public AppTemplateConversionUnitController(IAppTemplateConversionUnitService appTemplateConversionUnitService)
        {
            _appTemplateConversionUnitService = appTemplateConversionUnitService;
        }

        /// <summary>
        /// Get Template Conversio nUnit
        ///  Retorna Lista de template
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppTemplateConversionUnitQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetTemplateConversionUnit(AppTemplateConversionUnitQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var recipes = await _appTemplateConversionUnitService.GetTemplateByUnitsInput(filters);
                return Ok(recipes);



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
        /// Get Template Conversio nUnit
        ///  Retorna Lista de template
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppTemplateConversionUnitQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllTemplateConversionUnit(AppTemplateConversionUnitQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };

                
            try
            {


                var recipes = await _appTemplateConversionUnitService.GetAllTemplateByUnitsInput(filters);
                return Ok(recipes);



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
        /// Actualiza TemplateConversionUnit y Retorna los datos de AppTemplateConversionUnitGenericGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppTemplateConversionUnitGenericGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateTemplateConversionUnit(AppTemplateConversionUnitUpdateDto dto)
        {



            var response = await _appTemplateConversionUnitService.UpdateAppTemplateConversionUnit(dto);
            return Ok(response);



        }


        /// <summary>
        /// Crea TemplateConversionUnit y Retorna los datos de AppTemplateConversionUnitGenericGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<AppTemplateConversionUnitGenericGetDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateTemplateConversionUnit(AppTemplateConversionUnitCreateDto dto)
        {



            var response = await _appTemplateConversionUnitService.CreateAppTemplateConversionUnit(dto);
            return Ok(response);



        }


        /// <summary>
        /// Elimina TemplateConversionUnit y Retorna los datos de AppTemplateConversionUnitGenericGetDto
        /// Filtros a aplicar NA, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">NA</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<Boolean>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteTemplateConversionUnit(AppTemplateConversionUnitDeleteDto dto)
        {



            var response = await _appTemplateConversionUnitService.DeleteAppTemplateConversionUnit(dto);
            return Ok(response);



        }

    }
}