using AppService.Core.EntitiesClientes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy265Repository
    {


        Task<Wsmy265> GetById(decimal id);
        Task Add(Wsmy265 entity);
        void Update(Wsmy265 entity);
        Task Delete(decimal id);
        Task<decimal> NextCorrelativoContactoCliente(decimal idCliente, string rif);

    }
}
