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
    public class AppRecipesController : ControllerBase
    {
        private readonly IAppRecipesServices _appRecipesServices;

        public AppRecipesController(IAppRecipesServices appRecipesServices)
        {
            _appRecipesServices = appRecipesServices;
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
        public async Task<IActionResult> CalulateRecipeByProduct(AppRecipesQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var recipes = await _appRecipesServices.CalulateRecipeByProduct(filters.AppproductsId);
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
        /// Busca receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetRecipesGetDtoByProductId(AppRecipesQueryFilter filters)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {


                var recipes = await _appRecipesServices.GetRecipesGetDtoByProductId(filters);
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
        /// Crea Variable en la Receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesCreateDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateAppRecipes(AppRecipesCreateDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {

                var recipes = await _appRecipesServices.CreateAppRecipes(dto);
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
        /// Actualiza Variable en la Receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesCreateDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateAppRecipes(AppRecipesUpdateDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {



                var recipes = await _appRecipesServices.UpdateAppRecipes(dto);
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
        /// Elimina Variable en la Receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesDeleteDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteAppRecipes(AppRecipesDeleteDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {
                await _appRecipesServices.ValidateAllReceipProduct();
                var recipes = await _appRecipesServices.DeleteAppRecipes(dto);
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
        /// Elimina Variable en la Receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppRecipesDeleteDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<bool>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> ValidateAllReceipProduct(AppRecipesDeleteDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {
                await _appRecipesServices.ValidateAllReceipProduct();

                return Ok();



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
        /// Copia receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppCopyRecipesDto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CopyRecipes(AppCopyRecipesDto dto)
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {

                var recipes = await _appRecipesServices.CopyRecipes(dto);
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
        /// Copia receta por Codigo de Producto
        ///  Retorna Lista de la Receta
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppCopyRecipesDto</param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppRecipesGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreaVariables()
        {

            Metadata metadata = new Metadata
            {
                IsValid = false,
                Message = "",
                TotalCount = 0
            };


            try
            {

                await _appRecipesServices.CreaVariables();
                return Ok();



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