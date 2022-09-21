using AppService.Core.EntitiesSpi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISpiNmt033Repository
    {
        Task<List<NMT033>> GetListByYearMonth(decimal fproAnocal, decimal mescal);

    }
}
