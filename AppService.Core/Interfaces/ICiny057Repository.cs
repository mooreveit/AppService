using AppService.Core.EntitiesFacturacion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICiny057Repository
    {

        Task<Ciny057> GetByNumero(int factura);
        Task<Cary028> GetNotaCreditoByNumero(int nota);
    }
}
