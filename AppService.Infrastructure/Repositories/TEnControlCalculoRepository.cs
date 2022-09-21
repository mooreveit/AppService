using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class TEnControlCalculoRepository: ITEnControlCalculoRepository
    {

        private readonly MCContext _context;

        public TEnControlCalculoRepository(MCContext context)
        {
            _context = context;
        }

        public async Task<List<TEnControlCalculo>> GetAll()
        {

            return await _context.TEnControlCalculo.ToListAsync();

        }

        public async Task<TEnControlCalculo> GetFirst()
        {
            return await _context.TEnControlCalculo.FirstOrDefaultAsync();
        }


        public async Task<TEnControlCalculo> GetById(int id)
        {
            return await _context.TEnControlCalculo.FindAsync(id);
        }

        public async Task<decimal> GetNextId()
        {
            decimal nextId;
            var controlCalculo = await GetFirst();

            nextId = controlCalculo.IdSolicitud + 1;
            controlCalculo.IdSolicitud = nextId;
            return  nextId;
        }


      

        public async Task Add(TEnControlCalculo entity)
        {
            await _context.TEnControlCalculo.AddAsync(entity);


        }



        public void Update(TEnControlCalculo entity)
        {
            _context.TEnControlCalculo.Update(entity);

        }

        public async Task Delete(int id)
        {
            TEnControlCalculo entity = await GetById(id);
            _context.TEnControlCalculo.Remove(entity);

        }



       

    }
}
