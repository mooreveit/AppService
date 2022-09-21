using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class MtrDireccionesRepository : IMtrDireccionesRepository
    {

        private readonly RRDContext _context;

        public MtrDireccionesRepository(RRDContext context)
        {
            _context = context;
        }

        public async Task<List<MtrDirecciones>> GetByIdCliente(string idCliente)
        {


            try
            {
                var result = await _context.MtrDirecciones.Where(x => x.Codigo == idCliente).ToListAsync();


                return result;
            }
            catch (Exception e)
            {
                var a = e.InnerException.Message;

                return null;
            }


        }

        public async Task<MtrDirecciones> GetById(decimal id)
        {

            try
            {
                var direcciones = await _context.MtrDirecciones.Where(x => x.Id == id).FirstOrDefaultAsync();
                return direcciones;
            }
            catch (Exception e)
            {
                var m = e.Message;

                return null;
            }



        }



    }
}
