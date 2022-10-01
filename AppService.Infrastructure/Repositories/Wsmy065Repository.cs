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

    }
}
