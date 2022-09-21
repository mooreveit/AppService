using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class CobTransaccionesRepository : ICobTransaccionesRepository
    {
        private readonly RRDContext _context;

        public CobTransaccionesRepository(RRDContext context)
        {
            _context = context;

        }

        public IEnumerable<CobTransacciones> GetAll()
        {

            return _context.CobTransacciones.AsEnumerable();

        }

        public List<CobTransacciones> GetAllEfectivo()
        {

            return _context.CobTransacciones.Where(x => x.Efectivo == true || x.Transaccion == "RE").ToList();

        }

        public List<CobTransacciones> GetAllImpuesto()
        {

            return _context.CobTransacciones.Where(x => x.Impuesto == true && x.Transaccion != "RE").ToList();

        }


        public async Task<CobTransacciones> GetById(int id)
        {
            return await _context.CobTransacciones.FindAsync(id);
        }

    }
}
