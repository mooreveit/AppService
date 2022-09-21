// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppIngredients
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppIngredients
  {
    public AppIngredients()
    {
      this.AppRecipes = (ICollection<AppService.Core.Entities.AppRecipes>) new HashSet<AppService.Core.Entities.AppRecipes>();
      this.AppRecipesByAppDetailQuotes = (ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes>) new HashSet<AppService.Core.Entities.AppRecipesByAppDetailQuotes>();
      this.AppUnitsofMeasureforIngredients = (ICollection<AppService.Core.Entities.AppUnitsofMeasureforIngredients>) new HashSet<AppService.Core.Entities.AppUnitsofMeasureforIngredients>();
    }

    public int Id { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public int AppUnitId { get; set; }

    public Decimal Cost { get; set; }

    public long? PrymaryMtrMonedaId { get; set; }

    public long? SecundaryMtrMonedaId { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MtrTipoMoneda PrymaryMtrMoneda { get; set; }

    public virtual MtrTipoMoneda SecundaryMtrMoneda { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppRecipes> AppRecipes { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes> AppRecipesByAppDetailQuotes { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppUnitsofMeasureforIngredients> AppUnitsofMeasureforIngredients { get; set; }
  }
}
