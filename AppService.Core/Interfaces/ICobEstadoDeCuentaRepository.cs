using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobEstadoDeCuentaRepository
    {
        IEnumerable<CobEstadoDeCuenta> GetAll();
        Task<List<CobEstadoDeCuenta>> GetAllDocumentoMadre(string idCliente);
        Task<CobEstadoDeCuenta> GetById(decimal id);
        Task<CobEstadoDeCuenta> GetByDocumentoSap(string id);
        Task Add(CobEstadoDeCuenta entity);
        void Update(CobEstadoDeCuenta entity);

        Task<List<IGrouping<string, CobEstadoDeCuenta>>> GetClientesConSaldo();

    }
}
