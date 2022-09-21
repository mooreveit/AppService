using AppService.Core.CustomEntities;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMtrOficinaRepository
    {

        IEnumerable<MtrOficina> GetAll(string usuario);
        Task<IEnumerable<MtrOficina>> ListOficinasPorUsuario(MtrOficinaQueryFilter filter);
        Task<MtrOficina> GetById(short id);
    }
}
