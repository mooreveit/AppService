using AppService.Core.EntitiesClientes;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataClientes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy265Repository:IWsmy265Repository
    {

        private readonly ClientesContext _context;

        public Wsmy265Repository(ClientesContext context)
        {
            _context = context;
        }

        public async Task<Wsmy265> GetById(decimal id)
        {
            return await _context.Wsmy265.FindAsync(id);
        }

        public async Task Add(Wsmy265 entity)
        {
            await _context.Wsmy265.AddAsync(entity);


        }



        public void Update(Wsmy265 entity)
        {
            _context.Wsmy265.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            Wsmy265 entity = await GetById(id);
            _context.Wsmy265.Remove(entity);

        }

        public async Task<decimal> NextCorrelativoContactoCliente(decimal idCliente,string rif)
        {
            var contactos = await _context.Wsmy265.OrderByDescending(x => x.Id).Where(x=>x.Cliente==idCliente &&  x.Rif==rif).FirstOrDefaultAsync();
            decimal next = 0;
            if (contactos!=null)
            {
                next = (decimal)contactos.IdContactos + 1;

            }
            else
            {
                next = 1;
            }

            return next;
        }

    }
}
