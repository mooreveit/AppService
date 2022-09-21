using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobPagosRetencionesRepository
    {

        IEnumerable<CobPagosRetenciones> GetAll();

        Task<CobPagosRetenciones> GetById(long id);

        Task Add(CobPagosRetenciones entity);

        void Update(CobPagosRetenciones entity);

        Task Delete(long id);

        List<CobPagosRetenciones> GetByIdCobranzas(long id);

        decimal GetTotalRetencionesByIdCobranzas(long id);

        Task<CobPagosRetenciones> GetByIdCobranzasTransaccion(long idCobranzas, int idTransaccion);
        Task<CobPagosRetenciones> GetByDocumentoSap(string documentoSap);
    }
}
