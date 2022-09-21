
using AppService.Core.EntitiesMC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ITPaTasaBancoCentralServices
    {

        IEnumerable<TPaTasaBancoCentral> GetAll();

        Task<TPaTasaBancoCentral> GetById(decimal id);

        Task<TPaTasaBancoCentral> Insert(TPaTasaBancoCentral tPaTasaBancoCentral);

        Task<TPaTasaBancoCentral> Update(TPaTasaBancoCentral tPaTasaBancoCentral);

        Task<bool> Delete(decimal id);

        Task<TPaTasaBancoCentral> GetTasaByFecha(DateTime fecha);

    }
}
