using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace AppService.Api.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class Nmm024Controller : ControllerBase
    {
        private readonly INmm024Service _nmm024Service;
        private readonly INmt033Service _nmt033Service;

        public Nmm024Controller(INmm024Service nmm024Service, INmt033Service nmt033Service)
        {
            _nmm024Service = nmm024Service;
            _nmt033Service = nmt033Service;
        }

        /// <summary>
        /// Retorna los datos de AppVariablesGetDto
        /// Filtros a aplicar AppVariablesQueryFilter, 
        /// se realizara el filtro de los datos
        /// </summary>
        /// <param name="filters">Filtros a aplicar AppVariablesQueryFilter, se realizara el filtro de los datos</param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateNmm024(Nmm024Filter filters)
        {
            await _nmt033Service.UpdateByYearMonth(filters.FproAnoCal, filters.MesCal);
            await _nmm024Service.UpdateByYearMonth(filters.FproAnoCal, filters.MesCal);
            return Ok(true);

        }

    }
}
