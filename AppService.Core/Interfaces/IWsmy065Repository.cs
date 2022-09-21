using AppService.Core.EntitiesClientes;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy065Repository
    {

        Task<Wsmy065> GetByRamo(decimal codigo);

    }
}
