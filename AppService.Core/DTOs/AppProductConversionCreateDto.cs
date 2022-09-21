// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppProductConversionCreateDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.DTOs
{
  public class AppProductConversionCreateDto
  {
    public int? AppProductsId { get; set; }

    public int? AppUnitsIdAlternativa { get; set; }

    public Decimal? XNumerador { get; set; }

    public int? AppUnitsIdBase { get; set; }

    public Decimal? YDenominador { get; set; }
  }
}
