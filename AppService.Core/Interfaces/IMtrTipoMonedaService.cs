using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrTipoMonedaService
    {

        IEnumerable<MtrTipoMoneda> GetAll(MtrTipoMonedaQueryFilter filters);


        Task<MtrTipoMoneda> GetById(long id);

        Task<MtrTipoMoneda> Insert(MtrTipoMoneda mtrTipoMoneda);

        Task<MtrTipoMoneda> Update(MtrTipoMoneda mtrTipoMoneda);

        Task<bool> Delete(long id);

    }
}
