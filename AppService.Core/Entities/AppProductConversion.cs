// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppProductConversion
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AppProductConversion
  {
    public int Id { get; set; }

    public int? AppProductsId { get; set; }

    public int? AppUnitsIdAlternativa { get; set; }

    public Decimal? XNumerador { get; set; }

    public int? AppUnitsIdBase { get; set; }

    public Decimal? YDenominador { get; set; }

    public virtual AppProducts AppProducts { get; set; }

    public virtual AppUnits AppUnitsIdAlternativaNavigation { get; set; }

    public virtual AppUnits AppUnitsIdBaseNavigation { get; set; }
  }
}
