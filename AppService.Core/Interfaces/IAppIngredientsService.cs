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
    public interface IAppIngredientsService
    {
        Task<List<AppIngredients>> GetAll();
        Task<ApiResponse<List<AppIngredientsGetDto>>> GetAllFilter(AppIngredientsQueryFilter filter);
        Task<AppIngredients> GetById(int id);
        Task<AppIngredients> Insert(AppIngredients appIngredients);
        Task<ApiResponse<AppIngredientsGetDto>> CreateAppIngredient(AppIngredientsCreateDto dto);
        Task<AppIngredients> Update(AppIngredients appIngredients);
        Task<ApiResponse<AppIngredientsGetDto>> UpdateAppIngredient(AppIngredientsUpdateDto dto);
        Task<bool> Delete(int id);
        Task<ApiResponse<bool>> DeleteAppIngredients(AppIngredientsDeleteDto dto);


    }
}
