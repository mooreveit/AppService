using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapCargoContactoRepository : ISapCargoContactoRepository
    {

        private readonly SapContext _context;

        public SapCargoContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<List<SapCargoContacto>> GetAll()
        {

            return await _context.SapCargoContacto.ToListAsync();

        }
        public async Task<SapCargoContacto> GetById(string id)
        {
            return await _context.SapCargoContacto.Where(x => x.Codigo == id).FirstOrDefaultAsync();
        }

        public async Task<SapCargoContacto> GetByIdDecimal(decimal id)
        {
            return await _context.SapCargoContacto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
