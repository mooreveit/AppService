
using AppService.Core.EntitiesCXC;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataCXC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wary074Repository
    {


        private readonly CXCContext _context;

        public Wary074Repository(CXCContext context)
        {
            _context = context;
        }

        public IEnumerable<Wary074> GetAll()
        {
          
            return _context.Wary074.AsEnumerable();

        }

        public async Task<Wary074> GetById(short id)
        {
            return await _context.Wary074.FindAsync(id);
        }

        public async Task Add(Wary074 entity)
        {
            await _context.Wary074.AddAsync(entity);


        }



        public void Update(Wary074 entity)
        {
            _context.Wary074.Update(entity);

        }

        public async Task Delete(short id)
        {
            Wary074 entity = await GetById(id);
            _context.Wary074.Remove(entity);

        }

    }
}
