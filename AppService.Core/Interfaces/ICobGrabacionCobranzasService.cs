using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobGrabacionCobranzasService
    {

        PagedList<CobGrabacionCobranzas> GetCobGrabacionCobranzas(CobGrabacionCobranzasQueryFilter filters);
        Task<CobGrabacionCobranzas> Insert(CobGrabacionCobranzas cobGrabacionCobranzas);
        Task<CobGrabacionCobranzas> Update(CobGrabacionCobranzas cobGrabacionCobranzas);
        Task<bool> Delete(long id);

        IEnumerable<CobGrabacionCobranzas> GetAll();
        Task<CobGrabacionCobranzas> GetById(long id);

        Task<bool> MontoCobradoEsTotal(long id);

        bool ReciboTieneCobro(long documento);

    
        decimal TotalAfectadoDocumento(long documento, decimal docafecta);
        decimal TotalDetalleRecibo(long documento);

        Task<bool> GrabacionCobranzasTieneRetencionCero(long documento);

        Task<bool> ReciboTienePendienteContabilizar(long documento);
    }
}
