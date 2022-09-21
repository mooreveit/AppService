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
    public class MotivoGanarPerderRepository: IMotivoGanarPerderRepository
    {



        private readonly MooreveContext _context;

        public MotivoGanarPerderRepository(MooreveContext context)
        {
            _context = context;
        }

        public async Task<List<Wsmy281>> GetAll()
        {

            return await _context.Wsmy281.ToListAsync();

        }


        public async Task<List<Wsmy281>> GetAllByCondicion(int codCondicion)
        {
            List<Wsmy281> result = new List<Wsmy281>();



                result = await _context.Wsmy281.Where(x => x.CodCondicion == codCondicion).ToListAsync();
            
          
          


            return result;

        }

        public async Task<Wsmy281> GetById(int id)
        {
            return await _context.Wsmy281.FindAsync(id);
        }

        public async Task Add(Wsmy281 entity)
        {
            await _context.Wsmy281.AddAsync(entity);


        }



        public void Update(Wsmy281 entity)
        {
            _context.Wsmy281.Update(entity);

        }

        public async Task Delete(int id)
        {
            Wsmy281 entity = await GetById(id);
            _context.Wsmy281.Remove(entity);

        }
    }
}
