using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppTemplateConversionUnitService
    {

        Task<List<AppTemplateConversionUnit>> GetTemplateByUnits(int appUnitIdSince, int appUnitIdUntil);

        Task<ApiResponse<List<AppTemplateConversionUnitGetDto>>> GetTemplateByUnitsInput(AppTemplateConversionUnitQueryFilter filter);

        Task<AppTemplateConversionUnit> GetById(int id);

        Task<AppTemplateConversionUnit> Insert(AppTemplateConversionUnit appTemplateConversionUnit);

        Task<AppTemplateConversionUnit> Update(AppTemplateConversionUnit appTemplateConversionUnit);

        Task<bool> Delete(int id);

        Task<ApiResponse<List<AppTemplateConversionUnitGenericGetDto>>> GetAllTemplateByUnitsInput(AppTemplateConversionUnitQueryFilter filter);


        Task<ApiResponse<AppTemplateConversionUnitGenericGetDto>> UpdateAppTemplateConversionUnit(AppTemplateConversionUnitUpdateDto dto);

        Task<ApiResponse<AppTemplateConversionUnitGenericGetDto>> CreateAppTemplateConversionUnit(AppTemplateConversionUnitCreateDto dto);

        Task<ApiResponse<bool>> DeleteAppTemplateConversionUnit(AppTemplateConversionUnitDeleteDto dto);


    }
}
