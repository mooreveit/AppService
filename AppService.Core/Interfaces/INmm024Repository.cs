using AppService.Core.EntitiesNomina;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface INmm024Repository
    {

        Task<List<Nmm024>> GetListByYearMonth(decimal FproAnocal, decimal mescal);
        void Add(Nmm024 entity);
        Task AddRange(List<Nmm024> entity);
        Task DeleteMonth(decimal fproAnocal, decimal mescal);

        void ExecEstadisticas(decimal año, decimal mes);
    }
}
