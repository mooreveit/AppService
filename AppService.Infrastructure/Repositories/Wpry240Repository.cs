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
    public class Wpry240Repository : IWpry240Repository
    {


        private readonly MooreveContext _context;

        public Wpry240Repository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Csmy011>> GetListTintasActivas()
        {

            return await _context.Csmy011.Where(x => x.FlagEliminada != "X").OrderByDescending(x => x.Frecuencia).ToListAsync();

        }

        public async Task<List<Wpry240>> GetAll()
        {

            return await _context.Wpry240.ToListAsync();

        }



        public async Task<Wpry240> GetByCotizacionRenglonPropuestaParte(string cotizacion, int renglon, int propuesta, int parte)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon && x.Propuesta == propuesta && x.IdParte == parte).FirstOrDefaultAsync();
        }
        public async Task<List<Wpry240>> GetByCotizacion(string cotizacion)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion).ToListAsync();
        }
        public async Task<List<Wpry240>> GetByCotizacionRenglon(string cotizacion, int renglon)
        {

            return await _context.Wpry240.Where(x => x.Cotizacion == cotizacion && x.Renglon == renglon).ToListAsync();
        }

        public async Task Add(Wpry240 entity)
        {


            try
            {
                await _context.Wpry240.AddAsync(entity);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
                throw;
            }
        }



        public void Update(Wpry240 entity)
        {
            _context.Wpry240.Update(entity).Property(x => x.Recnum).IsModified = false; ;

        }

        public async Task Delete(string cotizacion, int renglon, int propuesta, int parte)
        {
            Wpry240 entity = await GetByCotizacionRenglonPropuestaParte(cotizacion, renglon, propuesta, parte);
            _context.Wpry240.Remove(entity);

        }

    }
}
