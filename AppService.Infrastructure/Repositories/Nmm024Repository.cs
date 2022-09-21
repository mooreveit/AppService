using AppService.Core.EntitiesNomina;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataNomina;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Nmm024Repository : INmm024Repository
    {

        private readonly NominaContext _context;


        public Nmm024Repository(NominaContext context)
        {
            _context = context;

        }
        public async Task<List<Nmm024>> GetListByYearMonth(decimal FproAnocal, decimal mescal)
        {
            var result = await _context.NMM024.Where(x => x.FPRO_ANOCAL == FproAnocal && x.MESCAL == mescal).ToListAsync();
            return result;
        }

        public async Task AddRange(List<Nmm024> entity)
        {
            await _context.NMM024.AddRangeAsync(entity);

        }
        public void ExecEstadisticas(decimal año, decimal mes)
        {
            this._context.NMM024.FromSqlRaw("exec [POWERBI].[dbo].[Pa_UpdateT_NominaVentas]");

        }


        public void Add(Nmm024 entity)
        {
            try
            {
                _context.NMM024.Add(entity);
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

            _context.NMM024.RemoveRange(entities);
        }







    }
}
