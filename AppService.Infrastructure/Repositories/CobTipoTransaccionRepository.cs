using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobTipoTransaccionRepository:ICobTipoTransaccionRepository
    {
        private readonly RRDContext _context;

        public CobTipoTransaccionRepository(RRDContext context)
        {
            _context = context;

        }

        public IEnumerable<CobTipoTransaccion> GetAll()
        {

            return _context.CobTipoTransaccion.AsEnumerable();

        }

        public async Task<CobTipoTransaccion> GetById(string id)
        {
            return await _context.CobTipoTransaccion.Where(x => x.IdTipoTransaccion == id).FirstOrDefaultAsync();
        }

    }
}
