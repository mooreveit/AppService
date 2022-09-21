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
    public  class AppStatusQuoteRepository: IAppStatusQuoteRepository
    {


        private readonly RRDContext _context;

        public AppStatusQuoteRepository(RRDContext context)
        {
            _context = context;
        }

        public  async Task<List<AppStatusQuote>> GetAll()
        {

            return await _context.AppStatusQuote.ToListAsync();

        }

        public async Task<AppStatusQuote> GetById(int id)
        {
            return await _context.AppStatusQuote.FindAsync(id);
        }

        public async Task Add(AppStatusQuote entity)
        {
            await _context.AppStatusQuote.AddAsync(entity);


        }



        public void Update(AppStatusQuote entity)
        {
            _context.AppStatusQuote.Update(entity);

        }

        public async Task Delete(int id)
        {
            AppStatusQuote entity = await GetById(id);
            _context.AppStatusQuote.Remove(entity);

        }


        public async Task<AppStatusQuote> GetStatusGanada()
        {
            return await _context.AppStatusQuote.Where(x=>x.FlagGanada=="X").FirstOrDefaultAsync();
        }
        public async Task<AppStatusQuote> GetStatusPerdida()
        {
            return await _context.AppStatusQuote.Where(x => x.FlagPerdida == "X").FirstOrDefaultAsync();
        }

    }
}
