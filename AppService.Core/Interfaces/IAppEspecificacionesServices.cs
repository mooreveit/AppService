using AppService.Core.DTOs.Especificaciones;
using AppService.Core.Responses;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppEspecificacionesServices
    {
        Task<ApiResponse<EspecificacionesGetDto>> GetAllFilter(PartesFilter filter);
        Task<ApiResponse<EspecificacionesGetDto>> UpdateEspecificaciones(EspecificacionesUpdateDto dto);
    }
}
