using AppService.Core.EntitiesMooreve;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWsmy369Repository
    {
        Task<Wsmy369> GetByOrdenParte(decimal orden, int parte);

    }
}
