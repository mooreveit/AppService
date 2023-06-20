using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppDesarrolloEtiquetasPrimeRepository : IAppDesarrolloEtiquetasPrimeRepository
    {
        private readonly RRDContext _context;

        public AppDesarrolloEtiquetasPrimeRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppDesarrolloEtiquetasPrime>> GetAll()
        {

            return await _context.AppDesarrolloEtiquetasPrime.ToListAsync();

        }
       

        public async Task<AppDesarrolloEtiquetasPrime> GetByMedidaBasica(decimal medidaBasica)
        {
            try
            {
                var desarrollo = await _context.AppDesarrolloEtiquetasPrime.Where(x => medidaBasica >= x.Desde && medidaBasica <=x.Hasta ).FirstOrDefaultAsync();
                return desarrollo;

            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
      

        }
      



   

    }
}
