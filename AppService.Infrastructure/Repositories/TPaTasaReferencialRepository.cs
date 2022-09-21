using AppService.Core.EntitiesMC;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMc;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class TPaTasaReferencialRepository: ITPaTasaReferencialRepository
    {

        private readonly MCContext _context;

        public TPaTasaReferencialRepository(MCContext context)
        {
            _context = context;
        }

        public async Task<List<TPaTasaReferencial>> GetAll()
        {

            return await _context.TPaTasaReferencial.ToListAsync();

        }

        public async Task<TPaTasaReferencial> GetById(decimal id)
        {
            return await _context.TPaTasaReferencial.FindAsync(id);
        }

        public async Task Add(TPaTasaReferencial entity)
        {
            await _context.TPaTasaReferencial.AddAsync(entity);


        }



        public void Update(TPaTasaReferencial entity)
        {
            _context.TPaTasaReferencial.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            TPaTasaReferencial entity = await GetById(id);
            _context.TPaTasaReferencial.Remove(entity);

        }
        public async Task<TPaTasaReferencial> GetTasaByFecha(DateTime fecha)
        {
            try
            {
                return await _context.TPaTasaReferencial.Where(x => x.Fecha <= fecha).OrderByDescending(x => x.Fecha).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;
                throw;
            }


        }

    }
}
