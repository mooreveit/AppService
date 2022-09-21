using AppService.Core.EntitiesDw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IDwConsolidadoAnalisisDeVencimientoRepository
    {

        Task<List<IGrouping<double?, DwConsolidadoAnalisisDeVencimiento>>> GetClientesConSaldo();
    }
}
