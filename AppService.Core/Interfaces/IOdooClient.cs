using AppService.Core.CustomEntities;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IOdooClient
    {
        Task<Metadata> Post(StringContent data);
    }
}
