using AppService.Core.EntitiesNomina;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataNomina;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Nmt033Repository : INmt033Repository
    {

        private readonly NominaContext _context;


        public Nmt033Repository(NominaContext context)
        {
            _context = context;

        }
        public async Task<List<Nmt033>> GetListByYearMonth(decimal FproAnocal, decimal mescal)
        {
            try
            {
                var result = await _context.NMT033.Where(x => x.ANOCAL == FproAnocal && x.MESCAL == mescal).ToListAsync();
                return result;
            }
            catch (System.Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
                throw;
            }

        }

        public async Task AddRange(List<Nmt033> entity)
        {
            await _context.NMT033.AddRangeAsync(entity);

        }



        public void Add(Nmt033 entity)
        {
            try
            {
                _context.NMT033.Add(entity);
            }
            catch (System.Exception e)
            {
                var a = e.Message;
                throw;
            }



        }

        public async Task DeleteMonth(decimal fproAnocal, decimal mescal)
        {
            var entities = await GetListByYearMonth(fproAnocal, mescal);

            _context.NMT033.RemoveRange(entities);
        }







    }
}
