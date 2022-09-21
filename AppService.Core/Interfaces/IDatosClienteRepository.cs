using AppService.Core.DataContratosStock;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IDatosClienteRepository
    {

        Task<DatosCliente> GetByCotizacion(string cotizacion);
        Task Add(DatosCliente entity);
        void Update(DatosCliente entity);
        Task Delete(string cotizacion);
        decimal NextNumCot(string codVendedor);



    }
}
