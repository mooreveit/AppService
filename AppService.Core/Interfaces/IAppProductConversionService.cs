// Decompiled with JetBrains decompiler
// Type: AppService.Core.Interfaces.IAppProductConversionService
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductConversionService
    {
        ApiResponse<List<AppProductConversionGetDto>> GetAllByProduct(
          AppProductConversionFilter filters);

        Task<AppProductConversion> GetById(int id);

        Task<AppProductConversion> Insert(AppProductConversion appUnits);

        Task<ApiResponse<AppProductConversionGetDto>> InsertConversion(
          AppProductConversionCreateDto dto);

        Task<AppProductConversion> Update(AppProductConversion appUnits);

        Task<ApiResponse<AppProductConversionGetDto>> UpdateConversion(
          AppProductConversionUpdateDto dto);

        Task<bool> Delete(int id);

        Task<ApiResponse<AppProductConversionGetDto>> DeletePrice(
          int id);

        Task<bool> CopyConversion(AppCopyRecipesDto dto);

    }
}
