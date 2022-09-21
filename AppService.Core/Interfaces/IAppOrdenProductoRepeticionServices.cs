using AppService.Core.DTOs.Repeticiones;
using AppService.Core.Responses;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppOrdenProductoRepeticionServices
    {
        Task<ApiResponse<ListaRepeticiones>> GetAllFilter(AppOrdenProductoRepeticionFilterDto filter);

    }
}
