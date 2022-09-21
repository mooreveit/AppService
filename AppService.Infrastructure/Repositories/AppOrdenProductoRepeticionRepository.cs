using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppOrdenProductoRepeticionRepository : IAppOrdenProductoRepeticionRepository
    {

        private readonly RRDContext _context;

        public AppOrdenProductoRepeticionRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppOrdenProductoRepeticion>> GetAll()
        {

            return await _context.AppOrdenProductoRepeticion.ToListAsync();

        }

        public async Task<List<AppOrdenProductoRepeticion>> GetByCliente(string idCliente)
        {
            try
            {
                var repeticiones = await _context.AppOrdenProductoRepeticion.Where(x => x.IdCliente == idCliente).ToListAsync();

                return repeticiones;
            }
            catch (System.Exception ex)
            {
                var msg = ex.InnerException.Message;
                return null;
            }


        }



    }
}
