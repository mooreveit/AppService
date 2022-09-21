using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobMatrixMonedaValidaPagoRepository
    {

        IEnumerable<CobMatrixMonedaValidaPago> GetAll();

        Task<CobMatrixMonedaValidaPago> GetById(int id);

        Task Add(CobMatrixMonedaValidaPago entity);

        void Update(CobMatrixMonedaValidaPago entity);

        Task Delete(int id);


        Task<bool> ExisteMonedaDocumentoMonedaPago(string monedaDocumento, string monedaPago);




    }
}
