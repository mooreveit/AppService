using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wsmy645Repository : IWsmy645Repository
    {

        private readonly MooreveContext _context;

        public Wsmy645Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wsmy645>> GetAll()
        {

            return await _context.Wsmy645.ToListAsync();

        }

        public async Task<Wsmy645> GetById(decimal id)
        {

            return await _context.Wsmy645.FindAsync(id);
        }

        public async Task Add(Wsmy645 entity)
        {
            await _context.Wsmy645.AddAsync(entity);


        }



        public void Update(Wsmy645 entity)
        {
            _context.Wsmy645.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            Wsmy645 entity = await GetById(id);
            _context.Wsmy645.Remove(entity);

        }


        public async Task<Wsmy645> EstatusPendiente()
        {

            return await _context.Wsmy645.Where(x => x.FlagPendiente == "X").FirstOrDefaultAsync();
        }

        public async Task<Wsmy645> EstatusAprobado()
        {

            return await _context.Wsmy645.Where(x => x.FlagAprobado == "X").FirstOrDefaultAsync();
        }




    }
}
