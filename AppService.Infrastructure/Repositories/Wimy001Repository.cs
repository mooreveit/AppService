using AppService.Core.EntitiesMateriales;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMateriales;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wimy001Repository : IWimy001Repository
    {

        private readonly MaterialesContext _context;

        public Wimy001Repository(MaterialesContext context)
        {
            _context = context;
        }

        public async Task<List<Wimy001>> GetListByTipoPapelGramaje(string tipoPapel, string gramaje)
        {

            List<Wimy001> result = new List<Wimy001>();


            result = await _context.Wimy001s.Where(x => x.TipoPapel == tipoPapel && x.Gramaje == gramaje).ToListAsync();

            return result;

        }

    }
}
