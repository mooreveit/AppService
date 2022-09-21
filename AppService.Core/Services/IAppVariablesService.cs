using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public interface IAppVariablesService
    {
        Task<List<AppVariables>> GetAll();

        Task<AppVariables> GetById(int id);

        Task<AppVariables> Insert(AppVariables appVariables);

        Task<AppVariables> Update(AppVariables appVariables);
        Task<bool> Delete(int id);

        Task<ApiResponse<List<AppVariablesGetDto>>> GetAllFilter(AppVariablesQueryFilter filter);

        Task<ApiResponse<AppVariablesGetDto>> CreateVariables(AppVariablesCreateDto dto);

        Task<ApiResponse<AppVariablesGetDto>> UpdateVariables(AppVariablesUpdateDto dto);

        Task<ApiResponse<bool>> DeleteVariables(AppVariablesDeleteDto dto);
    }
}
