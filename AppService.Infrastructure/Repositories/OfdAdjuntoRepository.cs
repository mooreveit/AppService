using System;
using AppService.Core.Entities;
using System.Threading.Tasks;
using AppService.Infrastructure.Data;
using System.Linq;
using System.Data.Entity;
using AppService.Core.Interfaces;

namespace AppService.Infrastructure.Repositories
{
	public class OfdAdjuntoRepository: IOfdAdjuntoRepository
    {
	
        private readonly RRDContext _context;

        public OfdAdjuntoRepository(RRDContext context)
        {
            _context = context;
        }

       
        public async Task<OfdAdjunto> Add(OfdAdjunto entity)
        {
            await _context.OfdAdjunto.AddAsync(entity);


            return entity;
        }
      

        public async Task<OfdAdjunto> GetByFileName(string fileName)
        {
            return await _context.OfdAdjunto.Where(x=> x.NombreArchivo==fileName).FirstOrDefaultAsync();

        }


    }
}

