using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapTratamientoContactoRepository: ISapTratamientoContactoRepository
    {

        private readonly SapContext _context;

        public SapTratamientoContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<List<SapTratamientoContacto>> GetAll()
        {

            var result = await _context.SapTratamientoContacto.ToListAsync();
            return result;

        }

        public async Task<SapTratamientoContacto> GetById(short id)
        {
            return await _context.SapTratamientoContacto.FindAsync(id);
        }
    }
}
