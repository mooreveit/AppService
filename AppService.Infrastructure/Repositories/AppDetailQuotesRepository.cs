using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class AppDetailQuotesRepository : IAppDetailQuotesRepository
    {

        private readonly RRDContext _context;

        public AppDetailQuotesRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<AppDetailQuotes>> GetAll()
        {

            return await _context.AppDetailQuotes.ToListAsync();

        }


        public async Task<List<AppDetailQuotes>> GetByAppGeneralQuotesId(int appGeneralQuotesId)
        {
            return await _context.AppDetailQuotes.Where(x => x.AppGeneralQuotesId == appGeneralQuotesId).Include(x => x.AppGeneralQuotes).Include(x => x.IdEstatusNavigation).Include(x => x.IdProductoNavigation).ToListAsync();
        }
        public async Task<List<AppDetailQuotes>> GeSimpletByAppGeneralQuotesId(int appGeneralQuotesId)
        {
            return await _context.AppDetailQuotes.Where(x => x.AppGeneralQuotesId == appGeneralQuotesId).ToListAsync();
        }

        public async Task<bool> ExisteEnEspera(int appGeneralQuotesId)
        {

            bool result = false;
            var detail = await _context.AppDetailQuotes.Where(x => x.AppGeneralQuotesId == appGeneralQuotesId).ToListAsync();
            if (detail != null)
            {
                foreach (var item in detail)
                {
                    AppStatusQuote appStatusQuote = await _context.AppStatusQuote.Where(x => x.Id == item.IdEstatus).FirstOrDefaultAsync();
                    if (appStatusQuote.FlagEnEspera == "X")
                    {
                        result = true;
                    }
                }

                return result;
            }
            else
            {
                return false;
            }



        }





        public async Task<AppDetailQuotes> GetById(int id)
        {

            var detail = await _context.AppDetailQuotes.Include(x => x.IdProductoNavigation).Include(x => x.IdEstatusNavigation).Include(x => x.AppGeneralQuotes).Where(x => x.Id == id).FirstOrDefaultAsync();
            return detail;

        }

        public async Task<List<AppDetailQuotes>> GetByQuotesCotizacion(string cotizacion)
        {
            var detail = await _context.AppDetailQuotes.Where(x => x.Cotizacion == cotizacion).ToListAsync();

            return detail;

        }
        public async Task<AppDetailQuotes> GetByQuetesProduct(string cotizacion, int idProduct)
        {
            var detail = await _context.AppDetailQuotes.Where(x => x.Cotizacion == cotizacion && x.IdProducto == idProduct).FirstOrDefaultAsync();

            return detail;

        }
        public async Task<bool> ProductExistInQuotesDetail(int idProduct)
        {

            var detail = await _context.AppDetailQuotes.Where(x => x.IdProducto == idProduct).FirstOrDefaultAsync();
            if (detail != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public async Task Add(AppDetailQuotes entity)
        {

            var cotizacion = await GetByQuetesProduct(entity.Cotizacion, entity.IdProducto);

            if (cotizacion == null)
            {
                await _context.AppDetailQuotes.AddAsync(entity);
            }



        }



        public void Update(AppDetailQuotes entity)
        {
            _context.AppDetailQuotes.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppDetailQuotes entity = await GetById(id);
            _context.AppDetailQuotes.Remove(entity);

        }


    }
}
