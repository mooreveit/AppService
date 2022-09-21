using AppService.Core.EntitiesSpi;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSpi;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SpiNmm024Repository : ISpiNmm024Repository
    {

        private readonly SpiContext _context;


        public SpiNmm024Repository(SpiContext context)
        {
            _context = context;

        }

        public async Task<List<NMM024>> GetListByYearMonth(decimal fproAnocal, decimal mescal)
        {
            var result = await _context.NMM024.Where(x => x.FPRO_ANOCAL == fproAnocal && x.MESCAL == mescal).ToListAsync();
            return result;
        }


    }
}
