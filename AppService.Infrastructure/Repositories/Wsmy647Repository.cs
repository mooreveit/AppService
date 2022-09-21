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
    public class Wsmy647Repository: IWsmy647Repository
    {

        private readonly MooreveContext _context;

        public Wsmy647Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wsmy647>> GetAll()
        {

            return await _context.Wsmy647.ToListAsync();

        }
       
        public async Task<Wsmy647> Get(long idCalculo,int idRuta, int idEstacion )
        {
            return await _context.Wsmy647.Where(x=>x.IdCalculo== idCalculo && x.IdEstacion== idEstacion && x.IdRuta== idRuta).FirstOrDefaultAsync();
        }

        public async Task Add(Wsmy647 entity)
        {


            try
            {
                await _context.Wsmy647.AddAsync(entity);

            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                throw;
            }
           


        }



        public void Update(Wsmy647 entity)
        {
            _context.Wsmy647.Update(entity).Property(x => x.Recnum).IsModified = false; 

        }

       



    }
}
