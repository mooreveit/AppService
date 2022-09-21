using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapRetencionesRepository: ISapRetencionesRepository
    {
        private readonly RRDContext _context;

        public SapRetencionesRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<SapRetenciones> GetAll()
        {

            return _context.SapRetenciones.AsEnumerable();

        }

        public async Task<SapRetenciones> GetById(decimal id)
        {
            return await _context.SapRetenciones.FindAsync(id);
        }

        public async Task Add(SapRetenciones entity)
        {
            await _context.SapRetenciones.AddAsync(entity);


        }

        public SapRetenciones GetByTranzaccionPorcentaje(double transaccionLegacy, double porcentaje)
        {
            return _context.SapRetenciones.Where(x => x.TransaccionLegacy == transaccionLegacy && x.Porcentaje <= porcentaje).OrderBy(x=> x.Porcentaje).FirstOrDefault();
        }
        


        public void Update(SapRetenciones entity)
        {
            _context.SapRetenciones.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            SapRetenciones entity = await GetById(id);
            _context.SapRetenciones.Remove(entity);

        }


    }
}
