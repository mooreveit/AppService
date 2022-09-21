using AppService.Core.EntitiesDw;
using AppService.Core.Interfaces;
using AppService.Infrastructure.DataDW;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Infrastructure.Repositories
{
    public class DwConsolidadoAnalisisDeVencimientoRepository: IDwConsolidadoAnalisisDeVencimientoRepository
    {
        private readonly DWContext _context;

        public DwConsolidadoAnalisisDeVencimientoRepository(DWContext context)
        {
            _context = context;
        }

        public async Task<List<IGrouping<double?, DwConsolidadoAnalisisDeVencimiento>>> GetClientesConSaldo()
        {

            var estadoCuenta = await _context.DwConsolidadoAnalisisDeVencimiento.Where(X => X.Año == 22 && X.Mes == 2 && X.Saldo != 0).OrderBy(x => x.Id).ToListAsync();
            var groupCliente = estadoCuenta.GroupBy(u => u.An8).ToList();

            return groupCliente;

        }
       

    }
}
