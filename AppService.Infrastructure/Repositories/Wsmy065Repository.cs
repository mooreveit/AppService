using AppService.Core.EntitiesClientes;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataClientes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy065Repository : IWsmy065Repository
    {

        private readonly ClientesContext _context;

        public Wsmy065Repository(ClientesContext context)
        {
            _context = context;
        }

        public async Task AddRamo(Wsmy065 wsmy065)
        {
            await _context.Wsmy065.AddAsync(wsmy065);
        }

        public async Task AddSector(Wsmy064 wsmy064)
        {
            await _context.Wsmy064.AddAsync(wsmy064);
        }

        public async Task<Wsmy065> GetByRamo(decimal codigo)
        {
            Wsmy065 result = new Wsmy065();
            try
            {
                result = await _context.Wsmy065.Where(x => x.Ramo == codigo && x.FlagInactiva == false).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }

        public async Task<Wsmy064> GetSectorBySector(decimal codigo)
        {
            Wsmy064 result = new Wsmy064();
            try
            {
                result = await _context.Wsmy064.Where(x => x.Sector == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }



        public async Task<decimal> GetNextRamo()
        {
            Wsmy065 result = new Wsmy065();
            try
            {
                result = await _context.Wsmy065.OrderByDescending(x => x.Ramo).FirstOrDefaultAsync();

                return result.Ramo + 1;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return 0;
            }



        }
        public async Task<decimal> GetNextSector()
        {
            Wsmy064 result = new Wsmy064();
            try
            {
                result = await _context.Wsmy064.OrderByDescending(x => x.Sector).FirstOrDefaultAsync();

                return result.Sector + 1;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return 0;
            }



        }


        public async Task<Csmy003> GetClienteCsmy003(string codigo)
        {
            Csmy003 result = new Csmy003();
            try
            {
                result = await _context.Csmy003.Where(x => x.Codigo == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }


        public Csmy003 UpdateCsmy003(Csmy003 csmy003)
        {
            try
            {
                _context.Csmy003.Update(csmy003);
                return csmy003;
            }
            catch (System.Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }


        }

    }
}
