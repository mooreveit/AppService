

using AppService.Core.EntitiesEstadisticas;
using AppService.Core.EntitiesFacturacion;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataEstadisticas;
using AppService.Infrastructure.DataFacturacion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class VentasRepository : IVentasRepository
    {

        private readonly EstadisticasContext _context;

        public VentasRepository(EstadisticasContext context)
        {
            _context = context;
        }


        public async Task<Venta> GetByOrden(long orden)
        {
           
            try
            {
                var result = await _context.Ventas.Where(x => x.Orden == orden && x.Correlativo==0).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                var msg = e.InnerException.Message;
                return null;
            }



        }

     

    }
}
