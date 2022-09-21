using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrTipoMonedaRepository : IMtrTipoMonedaRepository
    {
        private readonly RRDContext _context;

        public MtrTipoMonedaRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<MtrTipoMoneda> GetAll()
        {

            return _context.MtrTipoMoneda.AsEnumerable();

        }

        public async Task<MtrTipoMoneda> GetById(long id)
        {
            return await _context.MtrTipoMoneda.FindAsync(id);
        }

        public async Task Add(MtrTipoMoneda entity)
        {
            await _context.MtrTipoMoneda.AddAsync(entity);


        }



        public void Update(MtrTipoMoneda entity)
        {
            _context.MtrTipoMoneda.Update(entity);

        }

        public async Task Delete(long id)
        {
            MtrTipoMoneda entity = await GetById(id);
            _context.MtrTipoMoneda.Remove(entity);

        }


    }
}
