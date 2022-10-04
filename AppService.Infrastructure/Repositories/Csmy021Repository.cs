using AppService.Core.EntitiesPlanta;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataPlanta;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Csmy021Repository : ICsmy021Repository
    {



        private readonly PlantaContext _context;

        public Csmy021Repository(PlantaContext context)
        {
            _context = context;
        }


        public async Task<List<Csmy021>> GetByOrdenAsync(long orden)
        {
            return await _context.Csmy021.Where(x => x.Orden == orden).ToListAsync();
        }


    }


}

