using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppConfigAppService
    {

        Task<ParametrosMaquina> getParametrosMaquina();

        Task<List<AppConfigApp>> GetAll();
        Task<ApiResponse<List<AppConfigAppGetDto>>> GetAllFilter(AppConfigAppQueryFilter filter);

        Task<AppConfigApp> GetById(int id);

        Task<AppConfigApp> Insert(AppConfigApp appConfigApp);
        Task<ApiResponse<AppConfigAppGetDto>> CreateAppConfig(AppConfigAppCreateDto dto);

        Task<AppConfigApp> Update(AppConfigApp appConfigApp);

        Task<ApiResponse<AppConfigAppGetDto>> UpdateAppConfig(AppConfigAppUpdateDto dto);

        Task<bool> Delete(int id);
        Task<ApiResponse<bool>> DeleteAppConfig(AppConfigAppDeleteDto dto);


        Task<AppConfigAppGetDto> GetByKey(string key);

    }
}
