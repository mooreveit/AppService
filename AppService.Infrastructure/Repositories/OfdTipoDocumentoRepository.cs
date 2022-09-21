using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class OfdTipoDocumentoRepository: IOfdTipoDocumentoRepository
    {

        private readonly RRDContext _context;

        public OfdTipoDocumentoRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<OfdTipoDocumento> GetAll()
        {

            return _context.OfdTipoDocumento.AsEnumerable();

        }

        public async Task<OfdTipoDocumento> GetById(short id)
        {
            return await _context.OfdTipoDocumento.FindAsync(id);
        }

        public async Task Add(OfdTipoDocumento entity)
        {
            await _context.OfdTipoDocumento.AddAsync(entity);


        }



        public void Update(OfdTipoDocumento entity)
        {
            _context.OfdTipoDocumento.Update(entity);

        }

        public async Task Delete(short id)
        {
            OfdTipoDocumento entity = await GetById(id);
            _context.OfdTipoDocumento.Remove(entity);

        }



    }
}
