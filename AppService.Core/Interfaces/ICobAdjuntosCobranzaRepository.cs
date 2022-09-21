using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobAdjuntosCobranzaRepository
    {

        IEnumerable<CobAdjuntosCobranza> GetAll();

        Task Add(CobAdjuntosCobranza entity);

        Task<List<CobAdjuntosCobranza>> GetAdjuntoRecibo(long recibo);

        Task<List<CobAdjuntosCobranza>> GetAdjuntoPorDocumento(long recibo);

        Task<bool> DocumentoTieneAdjunto(long recibo);

        Task DeleteByNameFile(long recibo, string nombreArchivo);

        Task<List<CobAdjuntosCobranza>> GetAdjuntoTiff();
    }


}
