// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppUnitsofMeasureforMaterials
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.Entities
{
  public class AppUnitsofMeasureforMaterials
  {
    public int Id { get; set; }

    public int? AppProductsId { get; set; }

    public int? AppUnitsId { get; set; }

    public Decimal? Numerator { get; set; }

    public Decimal? Denominator { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AppProducts AppProducts { get; set; }

    public virtual AppUnits AppUnits { get; set; }
  }
}
