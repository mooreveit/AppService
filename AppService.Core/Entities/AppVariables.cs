// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppVariables
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class AppVariables
  {
    public AppVariables()
    {
      this.AppDetailQuotesConversionUnit = (ICollection<AppService.Core.Entities.AppDetailQuotesConversionUnit>) new HashSet<AppService.Core.Entities.AppDetailQuotesConversionUnit>();
      this.AppProductVariableSearchText = (ICollection<AppService.Core.Entities.AppProductVariableSearchText>) new HashSet<AppService.Core.Entities.AppProductVariableSearchText>();
      this.AppRecipes = (ICollection<AppService.Core.Entities.AppRecipes>) new HashSet<AppService.Core.Entities.AppRecipes>();
      this.AppRecipesByAppDetailQuotes = (ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes>) new HashSet<AppService.Core.Entities.AppRecipesByAppDetailQuotes>();
      this.AppTemplateConversionUnit = (ICollection<AppService.Core.Entities.AppTemplateConversionUnit>) new HashSet<AppService.Core.Entities.AppTemplateConversionUnit>();
      this.AppVariableSearch = (ICollection<AppService.Core.Entities.AppVariableSearch>) new HashSet<AppService.Core.Entities.AppVariableSearch>();
    }

    public int Id { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public int TipoVariable { get; set; }

    public string UserCreate { get; set; }

    public string UserUpdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Entero { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnit { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppProductVariableSearchText> AppProductVariableSearchText { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppRecipes> AppRecipes { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes> AppRecipesByAppDetailQuotes { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppTemplateConversionUnit> AppTemplateConversionUnit { get; set; }

    public virtual ICollection<AppService.Core.Entities.AppVariableSearch> AppVariableSearch { get; set; }
  }
}
