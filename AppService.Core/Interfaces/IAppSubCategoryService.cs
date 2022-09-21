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
    public interface IAppSubCategoryService
    {
        Task<ApiResponse<List<AppSubCategoryGetDto>>> GetAll(AppSubCategoryQueryFilter filter);

        Task<AppSubCategory> GetById(int id);

        Task<AppSubCategory> Insert(AppSubCategory appSubCategory);

        Task<AppSubCategory> Update(AppSubCategory appSubCategory);

        Task<bool> Delete(short id);

       


    }
}
