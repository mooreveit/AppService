using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppProduct
    {
        public AppProduct()
        {
            AppDetailQuotes = new HashSet<AppDetailQuote>();
            AppPrices = new HashSet<AppPrice>();
            AppProductConversions = new HashSet<AppProductConversion>();
            AppProductVariableSearchTexts = new HashSet<AppProductVariableSearchText>();
            AppRecipes = new HashSet<AppRecipe>();
            AppRecipesByAppDetailQuotes = new HashSet<AppRecipesByAppDetailQuote>();
            AppUnitsofMeasureforMaterials = new HashSet<AppUnitsofMeasureforMaterial>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public int? AppUnitsId { get; set; }
        public int? ProductionUnitId { get; set; }
        public decimal UnitPrice { get; set; }
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
        public decimal? Existencia { get; set; }
        public decimal? CajasProgramadas { get; set; }
        public decimal? Disponible { get; set; }
        public bool? ValidadCantidadFija { get; set; }
        public decimal? CantidadFija { get; set; }
        public decimal? CantidadMinima { get; set; }
        public bool? Inventariable { get; set; }
        public int? TipoCalculo { get; set; }
        public int? CodAplicacion { get; set; }

        public virtual AppSubCategory AppSubCategory { get; set; }
        public virtual AppUnit AppUnits { get; set; }
        public virtual AppUnit ProductionUnit { get; set; }
        public virtual MtrTipoMonedum PrymaryMtrMoneda { get; set; }
        public virtual MtrTipoMonedum SecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppDetailQuote> AppDetailQuotes { get; set; }
        public virtual ICollection<AppPrice> AppPrices { get; set; }
        public virtual ICollection<AppProductConversion> AppProductConversions { get; set; }
        public virtual ICollection<AppProductVariableSearchText> AppProductVariableSearchTexts { get; set; }
        public virtual ICollection<AppRecipe> AppRecipes { get; set; }
        public virtual ICollection<AppRecipesByAppDetailQuote> AppRecipesByAppDetailQuotes { get; set; }
        public virtual ICollection<AppUnitsofMeasureforMaterial> AppUnitsofMeasureforMaterials { get; set; }
    }
}
