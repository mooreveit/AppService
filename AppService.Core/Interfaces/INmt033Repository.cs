using AppService.Core.EntitiesNomina;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface INmt033Repository
    {

        Task<List<Nmt033>> GetListByYearMonth(decimal FproAnocal, decimal mescal);
        Task AddRange(List<Nmt033> entity);
        void Add(Nmt033 entity);
        Task DeleteMonth(decimal fproAnocal, decimal mescal);

    }
}
