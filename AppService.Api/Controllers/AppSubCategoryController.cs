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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppSubCategoryController : ControllerBase
    {
        private readonly IAppSubCategoryService _appSubCategoryService;

        public AppSubCategoryController(IAppSubCategoryService appSubCategoryService)
        {
            _appSubCategoryService = appSubCategoryService;
        }

        /// <summary>
        /// Lista as Subcategorias de Producto
        ///  
        /// 
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppSubCategoryQueryFilter</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppSubCategoryGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAll(AppSubCategoryQueryFilter filter)
        {


                var result = await _appSubCategoryService.GetAll(filter);

            
                return Ok(result);





        }


    }
}