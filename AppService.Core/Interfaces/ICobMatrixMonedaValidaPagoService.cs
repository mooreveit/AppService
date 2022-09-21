using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobMatrixMonedaValidaPagoService
    {

        IEnumerable<CobMatrixMonedaValidaPago> GetAll();

        Task<CobMatrixMonedaValidaPago> GetById(int id);

        Task<CobMatrixMonedaValidaPago> Insert(CobMatrixMonedaValidaPago cobMatrixMonedaValidaPago);

        Task<CobMatrixMonedaValidaPago> Update(CobMatrixMonedaValidaPago cobMatrixMonedaValidaPago);

        Task<bool> Delete(int id);

        Task<bool> ExisteMonedaDocumentoMonedaPago(string monedaDocumento, string monedaPago);
    }
}
