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
    public interface IAppUnitsService
    {

        Task<ApiResponse<List<AppUnitsGetDto>>> GetAll(AppUnitsQueryFilter filters);


        Task<AppUnits> GetById(int id);

        Task<AppUnits> Insert(AppUnits appUnits);

        Task<AppUnits> Update(AppUnits appUnits);

        Task<bool> Delete(short id);

        Task<ApiResponse<List<AppUnitsGetDto>>> GetAppUnitsWithConversion(AppUnitsQueryFilter filters);
    }
}
