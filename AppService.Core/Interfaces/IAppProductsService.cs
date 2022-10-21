// Decompiled with JetBrains decompiler
// Type: AppService.Core.Interfaces.IAppProductsService
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductsService
    {

        Task SendAllToOdoo();
        Task<List<AppProducts>> GetAll();

        Task<AppProducts> GetById(int id);

        Task<AppProducts> Insert(AppProducts appProducts);

        Task<AppProducts> Update(AppProducts appProducts);

        Task<bool> Delete(int id);

        Task<ApiResponse<bool>> DeleteProduct(AppProductsDeleteDto dto);

        Task<ApiResponse<List<AppProductsGetDto>>> GetAll(
          AppProdutsQueryFilter filters);

        Task<ApiResponse<AppProductsGetDto>> UpdateProducts(
          AppProductsUpdateDto appProductsUpdateDto);

        Task<ApiResponse<AppProductsGetDto>> InsertProducts(
          AppProductsCreateDto appProductsCreateDto);

        Task<ApiResponse<List<AppProductsGetDto>>> GetAllByVariable(
          List<AppVariableSearchCompareQueryFilter> filter,
          int subCategoryId);

        Task<ApiResponse<AppProductsGetDto>> GetProduct(int id);

        Task<ApiResponse<AppProductsGetDto>> CopyProduct(int id);

        Task<Decimal> GetPrecio(int appProductId, Decimal cantidad);
    }
}
