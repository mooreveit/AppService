using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class TPaTasaBancoCentralRepository : ITPaTasaBancoCentralRepository
    {
        private readonly MCContext _context;

        public TPaTasaBancoCentralRepository(MCContext context)
        {
            _context = context;
        }

        public IEnumerable<TPaTasaBancoCentral> GetAll()
        {

            return _context.TPaTasaBancoCentral.AsEnumerable();

        }

        public async Task<TPaTasaBancoCentral> GetById(decimal id)
        {
            return await _context.TPaTasaBancoCentral.FindAsync(id);
        }

        public async Task Add(TPaTasaBancoCentral entity)
        {
            await _context.TPaTasaBancoCentral.AddAsync(entity);


        }



        public void Update(TPaTasaBancoCentral entity)
        {
            _context.TPaTasaBancoCentral.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            TPaTasaBancoCentral entity = await GetById(id);
            _context.TPaTasaBancoCentral.Remove(entity);

        }
        public async Task<TPaTasaBancoCentral> GetTasaByFecha(DateTime fecha)
        {
            try
            {
                var tPaTasaBancoCentral = await _context.TPaTasaBancoCentral.Where(x => x.Fecha <= fecha).OrderByDescending(x => x.Fecha).FirstOrDefaultAsync();
                return tPaTasaBancoCentral;
            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                throw;
            }


        }

    }
}
