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
    public class CobValoresRetencionesRepository: ICobValoresRetencionesRepository
    {


        private readonly RRDContext _context;

        public CobValoresRetencionesRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<CobValoresRetenciones> GetAll()
        {

            return _context.CobValoresRetenciones.AsEnumerable();

        }

        public async Task<CobValoresRetenciones> GetById(long id)
        {
            return await _context.CobValoresRetenciones.FindAsync(id);
        }

        public async Task Add(CobValoresRetenciones entity)
        {
            await _context.CobValoresRetenciones.AddAsync(entity);


        }



        public void Update(CobValoresRetenciones entity)
        {
            _context.CobValoresRetenciones.Update(entity);

        }

        public async Task Delete(long id)
        {
            CobValoresRetenciones entity = await GetById(id);
            _context.CobValoresRetenciones.Remove(entity);

        }

    }
}
