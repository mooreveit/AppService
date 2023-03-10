using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy406Repository: IWsmy406Repository
    {

        private readonly MooreveContext _context;

        public Wsmy406Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wsmy406>> GetAll()
        {

            return await _context.Wsmy406.ToListAsync();

        }

        public async Task<Wsmy406> GetById(short id)
        {

            return await _context.Wsmy406.FindAsync(id);
        }

        public async Task<Wsmy406> GetByProduct(string producto)
        {

            return await _context.Wsmy406.Where(x => x.IdProducto == producto).FirstOrDefaultAsync();
        }

        public async Task<Wsmy406> GetByCodAplicacion(int codAplicacion)
        {

            return await _context.Wsmy406.Where(x => x.CodAplicacion == codAplicacion).FirstOrDefaultAsync();
        }

        public async Task Add(Wsmy406 entity)
        {
            await _context.Wsmy406.AddAsync(entity);


        }



        public void Update(Wsmy406 entity)
        {
            _context.Wsmy406.Update(entity);

        }

        public async Task Delete(short id)
        {
            Wsmy406 entity = await GetById(id);
            _context.Wsmy406.Remove(entity);

        }

    }
}
