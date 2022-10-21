using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppValoresVariablesEspecificacionesPartesRepository : IAppValoresVariablesEspecificacionesPartesRepository
    {
        private readonly MooreveContext _context;

        public AppValoresVariablesEspecificacionesPartesRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<AppValoresVariablesEspecificacionesPartes>> GetListByIdVariable(string idVariable)
        {

            return await _context.AppValoresVariablesEspecificacionesPartes.Where(x => x.IdVariable == idVariable).ToListAsync();

        }

    }
}
