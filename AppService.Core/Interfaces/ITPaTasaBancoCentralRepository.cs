
using AppService.Core.EntitiesMC;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ITPaTasaBancoCentralRepository
    {

        IEnumerable<TPaTasaBancoCentral> GetAll();

        Task<TPaTasaBancoCentral> GetById(decimal id);
        Task Add(TPaTasaBancoCentral entity);
        void Update(TPaTasaBancoCentral entity);

        Task Delete(decimal id);

        Task<TPaTasaBancoCentral> GetTasaByFecha(DateTime fecha);

    }
}
