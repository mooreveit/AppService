using AppService.Core.EntitiesMooreve;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataMooreve;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class Wpry249Repository : IWpry249Repository
    {

        private readonly MooreveContext _context;

        public Wpry249Repository(MooreveContext context)
        {
            _context = context;
        }


        public async Task<List<ValoresAdicionalesProducto>> BuscacaValoresAdicionales(string linea, string familia)
        {
            try
            {




                //var result = await _context.Database.ExecuteSqlInterpolatedAsync($"EXEC proc @parm1={linea},@parm2={familia}");

                var result = await _context.ValoresAdicionalesProducto.FromSqlRaw<ValoresAdicionalesProducto>("AppBuscacaValoresAdicionales {0},{1}", linea, familia)
                    .ToListAsync();


                return result;
            }
            catch (System.Exception e)
            {
                var msg = e.InnerException.Message;
                throw;
            }





        }





    }
}
