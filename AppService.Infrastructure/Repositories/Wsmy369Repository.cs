using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy369Repository : IWsmy369Repository
    {

        private readonly MooreveContext _context;

        public Wsmy369Repository(MooreveContext context)
        {
            _context = context;
        }




        public async Task<Wsmy369> GetByOrdenParte(decimal orden, int parte)
        {

            return await _context.Wsmy369.Where(x => x.Orden == orden && x.Parte == parte).FirstOrDefaultAsync();
        }

    }
}
