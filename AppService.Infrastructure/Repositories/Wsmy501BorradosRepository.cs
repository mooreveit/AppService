using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy501BorradosRepository : IWsmy501BorradosRepository
    {



        private readonly MooreveContext _context;

        public Wsmy501BorradosRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy501Borrados>> GetAll()
        {

            return await _context.Wsmy501Borrados.ToListAsync();

        }

        public async Task<Wsmy501Borrados> GetById(decimal id)
        {
            return await _context.Wsmy501Borrados.FindAsync(id);
        }

        public async Task Add(Wsmy501Borrados entity)
        {
            await _context.Wsmy501Borrados.AddAsync(entity);


        }



        public void Update(Wsmy501Borrados entity)
        {
            _context.Wsmy501Borrados.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            Wsmy501Borrados entity = await GetById(id);
            _context.Wsmy501Borrados.Remove(entity);

        }

    }
}
