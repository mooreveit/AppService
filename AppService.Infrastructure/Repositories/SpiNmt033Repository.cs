using AppService.Core.EntitiesSpi;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSpi;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SpiNmt033Repository : ISpiNmt033Repository
    {

        private readonly SpiContext _context;


        public SpiNmt033Repository(SpiContext context)
        {
            _context = context;

        }

        public async Task<List<NMT033>> GetListByYearMonth(decimal fproAnocal, decimal mescal)
        {
            var result = await _context.NMT033.Where(x => x.ANOCAL == fproAnocal && x.MESCAL == mescal).ToListAsync();
            return result;
        }


    }
}
