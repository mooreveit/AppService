using AppService.Core.EntitiesPlanta;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ICpry012Repository
    {
        Task<Cpry012> GetByOrdenAsync(long orden);
    }
}
