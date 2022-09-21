using AppService.Core.EntitiesMooreve;
using AppService.Infrastructure.DataMooreve;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy515BorradosRepository
    {

        private readonly MooreveContext _context;

        public Wsmy515BorradosRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy515Borrados>> GetAll()
        {

            return await _context.Wsmy515Borrados.ToListAsync();

        }

        public async Task<Wsmy515Borrados> GetById(decimal id)
        {
            return await _context.Wsmy515Borrados.FindAsync(id);
        }

        public async Task Add(Wsmy515Borrados entity)
        {
            await _context.Wsmy515Borrados.AddAsync(entity);


        }



        public void Update(Wsmy515Borrados entity)
        {
            _context.Wsmy515Borrados.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            Wsmy515Borrados entity = await GetById(id);
            _context.Wsmy515Borrados.Remove(entity);

        }

    }
}
