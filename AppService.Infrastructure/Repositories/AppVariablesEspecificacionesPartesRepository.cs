using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppVariablesEspecificacionesPartesRepository : IAppVariablesEspecificacionesPartesRepository
    {
        private readonly MooreveContext _context;

        public AppVariablesEspecificacionesPartesRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<AppVariablesEspecificacionesPartes>> GetByCodAplicacion(int codAplicacion)
        {

            return await _context.AppVariablesEspecificacionesPartes.Where(x => x.CodAplicacion == codAplicacion && x.FlagGralParte == "").ToListAsync();

        }
        public async Task<List<AppVariablesEspecificacionesPartes>> GetByCodAplicacionGeneral(int codAplicacion)
        {

            return await _context.AppVariablesEspecificacionesPartes.Where(x => x.CodAplicacion == codAplicacion && x.FlagGralParte != "").ToListAsync();

        }



    }
}
