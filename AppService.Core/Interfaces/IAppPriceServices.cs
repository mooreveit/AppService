
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppPriceServices
    {
        Task<ApiResponse<List<AppPriceGetDto>>> GetAllByAppProduct(
          int appProductId);

        Task<ApiResponse<AppPriceGetDto>> GetAppPriceDtoById(int id);

        Task<AppPrice> GetById(int id);

        Task<AppPrice> Add(AppPrice entity);

        Task<AppPrice> Update(AppPrice entity);

        Task Delete(int id);

        Task<ApiResponse<AppPriceGetDto>> DeletePrice(int id);

        Task<ApiResponse<AppPriceGetDto>> InsertPrice(
          AppPriceCreateDto appPriceCreateDto);

        Task<ApiResponse<AppPriceGetDto>> UpdatePrice(
          AppPriceUpdateDto appPriceUpdateDto);

        Task<ApiResponse<AppPriceGetDto>> GetByProductoCantidad(
          int apprpoductId,
          Decimal cantidad);

        Task<ApiResponse<AppPriceGetDto>> GetPrice(
          int apprpoductId,
          Decimal cantidad);
    }
}
