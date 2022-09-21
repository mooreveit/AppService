using AppService.Core.DTOs;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IMunicipioServices
    {

        Task<ApiResponse<List<MunicipioGetDto>>> GetAllFilter(MunicipioQueryFilter filter);

    }
}
