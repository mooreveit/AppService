using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IWpry243Repository
    {


        Task<short> BuscarIdFrente();
        Task<short> BuscarIdRespaldo();

    }
}
