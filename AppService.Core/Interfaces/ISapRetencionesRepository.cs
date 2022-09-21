using AppService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapRetencionesRepository
    {
        IEnumerable<SapRetenciones> GetAll();
        Task<SapRetenciones> GetById(decimal id);
        Task Add(SapRetenciones entity);
        void Update(SapRetenciones entity);
        Task Delete(decimal id);

        SapRetenciones GetByTranzaccionPorcentaje(double transaccionLegacy, double porcentaje);


    }
}
