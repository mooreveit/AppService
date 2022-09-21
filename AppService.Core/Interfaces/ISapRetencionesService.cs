using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapRetencionesService
    {
        IEnumerable<SapRetenciones> GetAll();
        Task<SapRetenciones> GetById(decimal id);
        SapRetenciones GetByTranzaccionPorcentaje(double transaccionLegacy, double porcentaje);
        Task<SapRetenciones> Insert(SapRetenciones sapRetenciones);
        Task<SapRetenciones> Update(SapRetenciones sapRetenciones);
        Task<bool> Delete(decimal id);

    }
}
