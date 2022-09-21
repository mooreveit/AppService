using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface INmt033Service
    {
        Task UpdateByYearMonth(decimal fproAnocal, decimal mescal);

    }
}
