using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wpry229Repository: IWpry229Repository
    {

        private readonly MooreveContext _context;

        public Wpry229Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wpry229>> GetAll()
        {

            return await _context.Wpry229.ToListAsync();

        }

        public async Task<Wpry229> GetById(int id)
        {

            return await _context.Wpry229.FindAsync(id);
        }

        public async Task<Wpry229> GetByCotizacionRenglonPropuesta(string cotizacion ,int renglon, int propuesta)
        {

            return await _context.Wpry229.Where(x=>x.Cotizacion== cotizacion && x.Renglon==renglon && x.Propuesta==propuesta).FirstOrDefaultAsync();
        }

        public async Task<List<Wpry229>> GetByCotizacion(string cotizacion)
        {

            return await _context.Wpry229.Where(x => x.Cotizacion == cotizacion ).ToListAsync();
        }

        public async Task Add(Wpry229 entity)
        {
            await _context.Wpry229.AddAsync(entity);


        }



        public void Update(Wpry229 entity)
        {
            _context.Wpry229.Update(entity);

        }

        public async Task Delete(int id)
        {
            Wpry229 entity = await GetById(id);
            _context.Wpry229.Remove(entity);

        }


       


    }
}
