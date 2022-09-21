using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapDepartamentoContactoRepository : ISapDepartamentoContactoRepository
    {

        private readonly SapContext _context;

        public SapDepartamentoContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<List<SapDepartamentoContacto>> GetAll()
        {

            return await _context.SapDepartamentoContacto.ToListAsync();

        }
        public async Task<SapDepartamentoContacto> GetById(string id)
        {
            return await _context.SapDepartamentoContacto.Where(x => x.Codigo == id).FirstOrDefaultAsync();
        }

        public async Task<SapDepartamentoContacto> GetByIdDecimal(decimal id)
        {
            return await _context.SapDepartamentoContacto.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<SapDepartamentoContacto> GetByDescripcion(string descripcion)
        {
            return await _context.SapDepartamentoContacto.Where(x => x.Descripcion.Trim() == descripcion.Trim()).FirstOrDefaultAsync();
        }

    }
}
