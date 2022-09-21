using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class OfdCotizacionRepository: IOfdCotizacionRepository
    {


        private readonly RRDContext _context;

        public OfdCotizacionRepository(RRDContext context)
        {
            _context = context;
        }


        public IEnumerable<OfdCotizacion> GetAll()
        {
            return _context.OfdCotizacion.AsEnumerable();
        }

        public async Task<OfdCotizacion> GetById(long id)
        {
            return await _context.OfdCotizacion.FindAsync(id);
        }

        public async Task<OfdCotizacion> GetByCotizacion(string id)
        {
            return await _context.OfdCotizacion.Where(x => x.Cotizacion == id).FirstOrDefaultAsync();
        }

        public async Task Add(OfdCotizacion entity)
        {
            await _context.OfdCotizacion.AddAsync(entity);


        }



        public void Update(OfdCotizacion entity)
        {
            _context.OfdCotizacion.Update(entity);

        }

        public async Task Delete(string id)
        {
            OfdCotizacion entity = await GetByCotizacion(id);
            _context.OfdCotizacion.Remove(entity);

        }

    }
}
