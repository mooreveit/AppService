using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface INmm024Service
    {

        Task UpdateByYearMonth(decimal fproAnocal, decimal mescal);

    }
}
