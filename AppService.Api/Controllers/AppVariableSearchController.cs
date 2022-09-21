using AppService.Api.Responses;
using AppService.Core.DTOs;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AppVariableSearchController : ControllerBase
    {
        private readonly IAppVariableSearchService _appVariableSearchService;

        public AppVariableSearchController(IAppVariableSearchService appVariableSearchService)
        {
            _appVariableSearchService = appVariableSearchService;
        }


        /// <summary>
        /// Retorna los datos de AppVariableSearchGetDto
        /// Filtros a aplicar AppVariableSearchQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariableSearchQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AppVariableSearchGetDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAppVariableSearch(AppVariableSearchQueryFilter filters)
        {



            var response = await _appVariableSearchService.GetAllBySubCategory((int)filters.AppSubCategoryId);
            return Ok(response);



        }


        /// <summary>
        /// Retorna los datos de AppVariableSearchGetDto
        /// Filtros a aplicar AppVariableSearchQueryFilter,
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariableSearchQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(200, Type = typeof(ApiResponse<List<AppVariableSearchGetDto>>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetAllAppVariableSearchAgrupado(
          AppVariableSearchQueryFilter filters)
        {
            AppVariableSearchController searchController = this;
            var categoryGroupByVariable = await _appVariableSearchService.GetAllBySubCategoryGroupByVariable((int)filters.AppSubCategoryId);
            return (IActionResult)searchController.Ok((object)categoryGroupByVariable);
        }


    }
}