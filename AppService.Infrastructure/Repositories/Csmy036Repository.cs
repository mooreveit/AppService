using AppService.Core.EntitiesMaestros;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMaestros;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Csmy036Repository : ICsmy036Repository
    {

        private readonly IMaestrosContext _context;

        public Csmy036Repository(IMaestrosContext context)
        {
            _context = context;
        }


        public async Task<Csmy036> GetByCode(string codigo)
        {
            Csmy036 result = new Csmy036();
            try
            {
                result = await _context.Csmy036.Where(x => x.CodigoProduct == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }
        public async Task<Civy004> GetCivy004ByCode(string codigo)
        {
            Civy004 result = new Civy004();
            try
            {
                result = await _context.Civy004.Where(x => x.Producto == codigo).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {

                return null;
            }



        }



    }
}
