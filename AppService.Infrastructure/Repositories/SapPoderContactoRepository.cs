using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapPoderContactoRepository : ISapPoderContactoRepository
    {

        private readonly SapContext _context;

        public SapPoderContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<List<SapPoderContacto>> GetAll()
        {

            return await _context.SapPoderContacto.ToListAsync();

        }

        public async Task<SapPoderContacto> GetById(string id)
        {
            return await _context.SapPoderContacto.Where(x => x.Codigo == id).FirstOrDefaultAsync();
        }

        public async Task<SapPoderContacto> GetByIdDecimal(decimal id)
        {
            return await _context.SapPoderContacto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
