using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrBancosService
    {

        Task<List<MtrBancos>> GetAll();
        Task<IEnumerable<MtrBancosDto>> GetAllFilter(MtrBancosQueryFilter filters);
        Task<MtrBancos> GetByCodigo(string id);
        Task<MtrBancos> Insert(MtrBancos mtrBancos);
        Task<MtrBancos> Update(MtrBancos mtrBancos);
        Task<bool> Delete(string id);
    }
}
