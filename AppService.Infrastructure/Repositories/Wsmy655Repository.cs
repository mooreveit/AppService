using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy655Repository: IWsmy655Repository
    {

        private readonly MooreveContext _context;

        public Wsmy655Repository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy655>> GetAll()
        {

            return await _context.Wsmy655.ToListAsync();

        }
    
        public async Task<Wsmy655> GetById(decimal id) { 
  
            return await _context.Wsmy655.FindAsync(id);
        }

        public async Task Add(Wsmy655 entity)
        {
            await _context.Wsmy655.AddAsync(entity);


        }



        public void Update(Wsmy655 entity)
        {
            _context.Wsmy655.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            Wsmy655 entity = await GetById(id);
            _context.Wsmy655.Remove(entity);

        }


    }
}
