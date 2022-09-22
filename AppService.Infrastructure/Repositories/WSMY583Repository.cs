using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class WSMY583Repository : IWSMY583Repository
    {

        private readonly MooreveContext _context;

        public WSMY583Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<Wsmy583>> GetAll()
        {

            return await _context.Wsmy583.ToListAsync();

        }

        public async Task<Wsmy583> GetById(int id)
        {

            return await _context.Wsmy583.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Wsmy583> GetByProductoMedidaMascara(string producto, string medidaMascara)
        {

            return await _context.Wsmy583.Where(x => x.Producto == producto && x.MedidaMascara == medidaMascara).FirstOrDefaultAsync();
        }

        public async Task<Wsmy583> GetByProductoMedidaFraccion(string producto, string medidaFraccion)
        {

            return await _context.Wsmy583.Where(x => x.Producto == producto && x.MedidaFraccion == medidaFraccion).FirstOrDefaultAsync();
        }


        public async Task Add(Wsmy583 entity)
        {
            await _context.Wsmy583.AddAsync(entity);


        }



        public void Update(Wsmy583 entity)
        {
            _context.Wsmy583.Update(entity).Property(x => x.Id).IsModified = false; ;

        }
        public async Task Delete(int id)
        {
            Wsmy583 entity = await GetById(id);
            _context.Wsmy583.Remove(entity);

        }



    }
}
