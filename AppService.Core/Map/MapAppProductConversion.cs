// Decompiled with JetBrains decompiler
// Type: AppService.Core.Map.MapAppProductConversion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using AppService.Core.DTOs;
using AppService.Core.Entities;

namespace AppService.Core.Map
{
  public static class MapAppProductConversion
  {
    public static AppProductConversionGetDto MapAppProductConversionToAppProductConversionGetDto(
      AppProductConversion origen)
    {
      return new AppProductConversionGetDto()
      {
        Id = origen.Id,
        AppProductsId = origen.AppProductsId,
        AppUnitsIdBase = origen.AppUnitsIdBase,
        AppUnitsIdAlternativa = origen.AppUnitsIdAlternativa,
        XNumerador = origen.XNumerador,
        YDenominador = origen.YDenominador,
        AppUnitsAlternativaDescription = origen.AppUnitsIdAlternativaNavigation.Description1,
        AppUnitsBaseDescription = origen.AppUnitsIdBaseNavigation.Description1
      };
    }

    public static AppProductConversion MapAppProductConversionGetDtoToAppProductConversion(
      AppProductConversionGetDto origen)
    {
      return new AppProductConversion()
      {
        Id = origen.Id,
        AppProductsId = origen.AppProductsId,
        AppUnitsIdBase = origen.AppUnitsIdBase,
        AppUnitsIdAlternativa = origen.AppUnitsIdAlternativa,
        XNumerador = origen.XNumerador,
        YDenominador = origen.YDenominador
      };
    }

    public static AppProductConversion MapAppProductConversionCreateDtoToAppProductConversion(
      AppProductConversionCreateDto origen)
    {
      return new AppProductConversion()
      {
        AppProductsId = origen.AppProductsId,
        AppUnitsIdBase = origen.AppUnitsIdBase,
        AppUnitsIdAlternativa = origen.AppUnitsIdAlternativa,
        XNumerador = origen.XNumerador,
        YDenominador = origen.YDenominador
      };
    }

    public static AppProductConversion MapAppProductConversionUpdateDtoToAppProductConversion(
      AppProductConversionUpdateDto origen)
    {
      return new AppProductConversion()
      {
        Id = origen.Id,
        AppProductsId = origen.AppProductsId,
        AppUnitsIdBase = origen.AppUnitsIdBase,
        AppUnitsIdAlternativa = origen.AppUnitsIdAlternativa,
        XNumerador = origen.XNumerador,
        YDenominador = origen.YDenominador
      };
    }
  }
}
