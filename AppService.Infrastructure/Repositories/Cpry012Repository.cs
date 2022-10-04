using AppService.Core.EntitiesPlanta;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataPlanta;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Cpry012Repository : ICpry012Repository
    {

        private readonly PlantaContext _context;

        public Cpry012Repository(PlantaContext context)
        {
            _context = context;
        }


        public async Task<Cpry012> GetByOrdenAsync(long orden)
        {
            return await _context.Cpry012.Where(x => x.Orden == orden).FirstOrDefaultAsync();
        }
    }
}
