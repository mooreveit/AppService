using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobGrabacionCobranzasRepository
    {
        IEnumerable<CobGrabacionCobranzas> GetAll();
        Task<CobGrabacionCobranzas> GetById(long id);
        Task Add(CobGrabacionCobranzas entity);
        Task Update(CobGrabacionCobranzas entity);
        Task Delete(long id);
        List<CobGrabacionCobranzas> GetByDocumento(long id);
   
        decimal TotalAfectadoDocumento(long documento, decimal docafecta);
        decimal TotalDetalleRecibo(long documento);

        Task<bool> GrabacionCobranzasTieneRetencionCero(long documento);

        Task<bool> ReciboTienePendienteContabilizar(long documento);

        CobGrabacionCobranzas GetByDocumentoAfecta(decimal docAfecta);
        Task<CobGrabacionCobranzas> GetByDocumentoSap(string documentoSap);
        Task<bool> FacturaTieneRetencionesPendientes(long documento);
    }
}
