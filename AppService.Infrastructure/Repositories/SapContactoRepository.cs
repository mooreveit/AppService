using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataSap;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class SapContactoRepository : ISapContactoRepository
    {

        private readonly SapContext _context;

        public SapContactoRepository(SapContext context)
        {
            _context = context;
        }

        public async Task<SapContactos> GetById(decimal id)
        {
            return await _context.SapContactos.FindAsync(id);
        }


        public async Task<SapContactos> GetByIdContacto(decimal id)
        {
            return await _context.SapContactos.Where(x => x.IdContacto == id).FirstOrDefaultAsync();
        }

        public async Task Add(SapContactos entity)
        {
            await _context.SapContactos.AddAsync(entity);


        }



        public void Update(SapContactos entity)
        {
            _context.SapContactos.Update(entity);

        }

        public async Task Delete(decimal id)
        {
            SapContactos entity = await GetById(id);
            _context.SapContactos.Remove(entity);

        }

        public async Task<decimal> NextId()
        {
            var sapContactos = await _context.SapContactos.OrderByDescending(x => x.IdContacto).FirstOrDefaultAsync();

            return sapContactos.IdContacto + 1;
        }



    }
}
