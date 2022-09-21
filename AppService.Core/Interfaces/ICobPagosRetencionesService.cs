using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICobPagosRetencionesService
    {
        IEnumerable<CobPagosRetenciones> GetAll();

        Task<CobPagosRetenciones> GetById(long id);

        Task<CobPagosRetenciones> Insert(CobPagosRetenciones cobPagosRetenciones);

        Task<CobPagosRetenciones> Update(CobPagosRetenciones cobPagosRetenciones);

        Task<bool> Delete(long id);

        IEnumerable<CobPagosRetenciones> GetListCobPagosRetenciones(CobPagosRetencionesQueryFilter filters);

        Task<Metadata> ValidateInsert(CobPagosRetenciones cobPagosRetenciones);

        decimal GetTotalRetencionesByIdCobranzas(long id);

    }
}
