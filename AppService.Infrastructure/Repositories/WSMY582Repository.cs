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
    public class WSMY582Repository: IWSMY582Repository
    {

        private readonly MooreveContext _context;

        public WSMY582Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wsmy582>> GetAll()
        {

            return await _context.Wsmy582.ToListAsync();

        }

        public async Task<Wsmy582> GetById(int id)
        {

            return await _context.Wsmy582.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Wsmy582> GetByProductoMedidaMascara(string producto, string medidaMascara)
        {

            return await _context.Wsmy582.Where(x => x.Producto == producto && x.MedidaMascara == medidaMascara).FirstOrDefaultAsync();
        }

        public async Task Add(Wsmy582 entity)
        {
            await _context.Wsmy582.AddAsync(entity);


        }



        public void Update(Wsmy582 entity)
        {
            _context.Wsmy582.Update(entity).Property(x => x.Id).IsModified = false; ;

        }
        public async Task Delete(int id)
        {
            Wsmy582 entity = await GetById(id);
            _context.Wsmy582.Remove(entity);

        }



    }
}
