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
   public  class CobSysfileRepository: ICobSysfileRepository
    {

        private readonly RRDContext _context;

        public CobSysfileRepository(RRDContext context)
        {
            _context = context;
        }

        public IEnumerable<CobSysfile> GetAll()
        {

            return _context.CobSysfile.AsEnumerable();

        }

        public async Task<CobSysfile> GetById(short id)
        {
            return await _context.CobSysfile.FindAsync(id);
        }

        public async Task Add(CobSysfile entity)
        {
            await _context.CobSysfile.AddAsync(entity);


        }



        public void Update(CobSysfile entity)
        {
            _context.CobSysfile.Update(entity);

        }

        public async Task Delete(short id)
        {
            CobSysfile entity = await GetById(id);
            _context.CobSysfile.Remove(entity);

        }

    }
}
