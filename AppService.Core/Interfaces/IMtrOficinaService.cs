using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrOficinaService
    {

        Task<PagedList<MtrOficina>> ListOficinasPorUsuario(MtrOficinaQueryFilter filter);
        Task<MtrOficina> GetOficina(short id);
    }
}
