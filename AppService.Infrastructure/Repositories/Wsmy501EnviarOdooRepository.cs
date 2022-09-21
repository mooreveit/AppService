using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy501EnviarOdooRepository : IWsmy501EnviarOdooRepository
    {
        private readonly MooreveContext _context;

        public Wsmy501EnviarOdooRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy501EnviarOdoo>> GetAll()
        {

            return await _context.Wsmy501EnviarOdoo.ToListAsync();

        }

        public async Task<Wsmy501EnviarOdoo> GetById(int id)
        {
            return await _context.Wsmy501EnviarOdoo.FindAsync(id);
        }

        public async Task Add(Wsmy501EnviarOdoo entity)
        {
            await _context.Wsmy501EnviarOdoo.AddAsync(entity);


        }



        public void Update(Wsmy501EnviarOdoo entity)
        {
            _context.Wsmy501EnviarOdoo.Update(entity);

        }

        public async Task Delete(int id)
        {
            Wsmy501EnviarOdoo entity = await GetById(id);
            _context.Wsmy501EnviarOdoo.Remove(entity);

        }


    }
}
