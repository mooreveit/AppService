// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppProducts
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class AppProducts
    {
        public AppProducts()
        {
            this.AppDetailQuotes = (ICollection<AppService.Core.Entities.AppDetailQuotes>)new HashSet<AppService.Core.Entities.AppDetailQuotes>();
            this.AppProductVariableSearchText = (ICollection<AppService.Core.Entities.AppProductVariableSearchText>)new HashSet<AppService.Core.Entities.AppProductVariableSearchText>();
            this.AppProductConversion = (ICollection<AppService.Core.Entities.AppProductConversion>)new HashSet<AppService.Core.Entities.AppProductConversion>();
            this.AppRecipes = (ICollection<AppService.Core.Entities.AppRecipes>)new HashSet<AppService.Core.Entities.AppRecipes>();
            this.AppPrices = (ICollection<AppPrice>)new HashSet<AppPrice>();
            this.AppUnitsofMeasureforMaterials = (ICollection<AppService.Core.Entities.AppUnitsofMeasureforMaterials>)new HashSet<AppService.Core.Entities.AppUnitsofMeasureforMaterials>();
            this.AppRecipesByAppDetailQuotes = (ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes>)new HashSet<AppService.Core.Entities.AppRecipesByAppDetailQuotes>();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public int? AppUnitsId { get; set; }

        public int? ProductionUnitId { get; set; }

        public Decimal UnitPrice { get; set; }

        public long? PrymaryMtrMonedaId { get; set; }

        public long? SecundaryMtrMonedaId { get; set; }

        public string UrlImage { get; set; }

        public int? AppSubCategoryId { get; set; }

        public string UserCreate { get; set; }

        public string UserUpdate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string VariablesSearchText { get; set; }

        public string ExternalCode { get; set; }

        public int? QuantityPerPackage { get; set; }

        public bool? AceptaMultiplesItem { get; set; }

        public bool? RequiereDatosEntrada { get; set; }

        public Decimal? Existencia { get; set; }

        public Decimal? CajasProgramadas { get; set; }

        public Decimal? Disponible { get; set; }

        public bool? ValidadCantidadFija { get; set; }

        public Decimal? CantidadFija { get; set; }

        public Decimal? CantidadMinima { get; set; }

        public bool Inventariable { get; set; }

        public int TipoCalculo { get; set; }

        public int CodAplicacion { get; set; }

        public bool RequiereEstimacion { get; set; }

        public virtual AppSubCategory AppSubCategory { get; set; }

        public virtual AppUnits AppUnits { get; set; }

        public virtual AppUnits ProductionUnit { get; set; }

        public virtual MtrTipoMoneda PrymaryMtrMoneda { get; set; }

        public virtual MtrTipoMoneda SecundaryMtrMoneda { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppDetailQuotes> AppDetailQuotes { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppProductVariableSearchText> AppProductVariableSearchText { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppRecipes> AppRecipes { get; set; }

        public virtual ICollection<AppPrice> AppPrices { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppProductConversion> AppProductConversion { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppRecipesByAppDetailQuotes> AppRecipesByAppDetailQuotes { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppUnitsofMeasureforMaterials> AppUnitsofMeasureforMaterials { get; set; }
    }
}
