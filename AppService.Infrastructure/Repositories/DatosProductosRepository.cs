using AppService.Core.DataContratosStock;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataContratosStock;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class DatosProductosRepository : IDatosProductosRepository
    {

        private readonly ContratosStockContext _context;

        public DatosProductosRepository(ContratosStockContext context)
        {
            _context = context;

        }

        public async Task<DatosProductos> GetByNumCotProducto(decimal numCot, string producto)
        {
            return await _context.DatosProductos.Where(x => x.NumCot == numCot && x.Codigo == producto).FirstOrDefaultAsync();
        }

        public async Task Add(DatosProductos entity)
        {
            await _context.DatosProductos.AddAsync(entity);


        }



        public void Update(DatosProductos entity)
        {
            _context.DatosProductos.Update(entity);

        }

        public async Task Delete(decimal numCot, string producto)
        {
            DatosProductos entity = await GetByNumCotProducto(numCot, producto);
            _context.DatosProductos.Remove(entity);

        }

        public async Task DeleteByCotizacion(string cotizacion)
        {
            var detail = await _context.DatosProductos.Where(x => x.CotizacionGeneral == cotizacion).ToListAsync();
            if (detail != null && detail.Count > 0)
            {
                _context.RemoveRange(detail);

            }

        }


    }
}
