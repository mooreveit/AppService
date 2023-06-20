using System;
using AppService.Core.Entities;
using System.Threading.Tasks;
using AppService.Infrastructure.Data;
using System.Linq;
using System.Data.Entity;
using AppService.Core.Interfaces;

namespace AppService.Infrastructure.Repositories
{
	public class OfdAdjuntoCriterioRepository : IOfdAdjuntoCriterioRepository
    {
	
        private readonly RRDContext _context;

        public OfdAdjuntoCriterioRepository(RRDContext context)
        {
            _context = context;
        }

       
        public async Task<OfdAdjuntoCriterio> Add(OfdAdjuntoCriterio entity)
        {
            await _context.OfdAdjuntoCriterio.AddAsync(entity);

            return entity;
        }
      

        


    }
}

