using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobAdjuntosCobranzaService
    {
        Task<PagedList<CobAdjuntosCobranza>> GetCobAdjuntosCobranza(AdjuntosCobranzaFilter filters);

        Task<CobAdjuntosCobranza> Insert(CobAdjuntosCobranza cobAdjuntosCobranza);


        Task<List<CobAdjuntosCobranza>> GetCobAdjuntosCobranzaRecibo(long recibo);

        Task<bool> DocumentoTieneAdjunto(long recibo);

        Task DeleteByNameFile(long recibo, string nombreArchivo);

        Task<List<CobAdjuntosCobranza>> GetCobAdjuntosCTiff();

    }
}
