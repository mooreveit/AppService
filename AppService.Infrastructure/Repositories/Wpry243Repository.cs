using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wpry243Repository : IWpry243Repository
    {
        private readonly MooreveContext _context;

        public Wpry243Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<short> BuscarIdFrente()
        {

            var wpry243 = await _context.Wpry243.Where(x => x.FlagFrente == "X").FirstOrDefaultAsync();
            return wpry243.IdUbicacion;
        }
        public async Task<short> BuscarIdRespaldo()
        {

            var wpry243 = await _context.Wpry243.Where(x => x.FlagRespaldo == "X").FirstOrDefaultAsync();
            return wpry243.IdUbicacion;
        }



    }
}
