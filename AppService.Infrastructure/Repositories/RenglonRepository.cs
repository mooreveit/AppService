using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class RenglonRepository : IRenglonRepository
    {

        private readonly MooreveContext _context;

        public RenglonRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy502>> GetAll()
        {

            return await _context.Wsmy502.ToListAsync();

        }




        public async Task<Wsmy502> GetById(int id)
        {
            return await _context.Wsmy502.FindAsync(id);
        }

        public async Task<List<Wsmy502>> GetByCotizacion(string cotizacion)
        {
            return await _context.Wsmy502.Where(x => x.Cotizacion == cotizacion).ToListAsync();
        }

        public async Task<Wsmy502> GetByCotizacionRenglon(string cotizacion, int renglon)
        {
            return await _context.Wsmy502.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon).FirstOrDefaultAsync();
        }

        public async Task<Wsmy502> GetByCotizacionProducto(string cotizacion, string producto)
        {
            try
            {
                var wsmy502 = await _context.Wsmy502.Where(x => x.Cotizacion == cotizacion && x.CodProducto == producto).FirstOrDefaultAsync();

                return wsmy502;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }


        }

        public async Task Add(Wsmy502 entity)
        {
            try
            {
                await _context.Wsmy502.AddAsync(entity);
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;

            }




        }



        public async Task Update(Wsmy502 entity)
        {
           _context.Wsmy502.Update(entity).Property(x => x.Id).IsModified = false;
           await  _context.SaveChangesAsync();

        }

        public async Task Delete(string cotizacion, int renglon)
        {
            Wsmy502 entity = await GetByCotizacionRenglon(cotizacion, renglon);
            _context.Wsmy502.Remove(entity);

        }

    }
}
