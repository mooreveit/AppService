using AppService.Core.EntitiesSpi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISpiNmm024Repository
    {

        Task<List<NMM024>> GetListByYearMonth(decimal fproAnocal, decimal mescal);
    }
}
