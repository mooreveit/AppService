// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppUnits
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppUnits
  {
    public AppUnits()
    {
      this.AppDetailQuotes = (ICollection<AppService.Core.Entities.AppDetailQuotes>) new HashSet<AppService.Core.Entities.AppDetailQuotes>();
      this.AppProductConversionAppUnitsIdAlternativaNavigation = (ICollection<AppProductConversion>) new HashSet<AppProductConversion>();
      this.AppProductConversionAppUnitsIdBaseNavigation = (ICollection<AppProductConversion>) new HashSet<AppProductConversion>();
      this.AppProductsAppUnits = (ICollection<AppProducts>) new HashSet<AppProducts>();
      this.AppProductsProductionUnit = (ICollection<AppProducts>) new HashSet<AppProducts>();
      this.AppTemplateConversionUnitAppUnitIdSinceNavigation = (ICollection<AppTemplateConversionUnit>) new HashSet<AppTemplateConversionUnit>();
      this.AppTemplateConversionUnitAppUnitIdUntilNavigation = (ICollection<AppTemplateConversionUnit>) new HashSet<AppTemplateConversionUnit>();
      this.AppUnitsofMeasureforIngredients = (ICollection<AppService.Core.Entities.AppUnitsofMeasureforIngredients>) new HashSet<AppService.Core.Entities.AppUnitsofMeasureforIngredients>();
      this.AppUnitsofMeasureforMaterials = (ICollection<AppService.Core.Entities.AppUnitsofMeasureforMaterials>) new HashSet<AppService.Core.Entities.AppUnitsofMeasureforMaterials>();
    }

    public int Id { get; set; }

    public string Code { get; set; }

    public string Description1 { get; set; }

    public string Description2 { get; set; }

    public string Description3 { get; set; }

    public string Description4 { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppDetailQuotes> AppDetailQuotes { get; set; }

    public virtual ICollection<AppProducts> AppProductsAppUnits { get; set; }

    public virtual ICollection<AppProductConversion> AppProductConversionAppUnitsIdAlternativaNavigation { get; set; }

    public virtual ICollection<AppProductConversion> AppProductConversionAppUnitsIdBaseNavigation { get; set; }

    public virtual ICollection<AppProducts> AppProductsProductionUnit { get; set; }

    public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdSinceNavigation { get; set; }

    public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdUntilNavigation { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }
  }
}
