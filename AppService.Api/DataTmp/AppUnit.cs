using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppUnit
    {
        public AppUnit()
        {
            AppDetailQuotes = new HashSet<AppDetailQuote>();
            AppProductAppUnits = new HashSet<AppProduct>();
            AppProductConversionAppUnitsIdAlternativaNavigations = new HashSet<AppProductConversion>();
            AppProductConversionAppUnitsIdBaseNavigations = new HashSet<AppProductConversion>();
            AppProductProductionUnits = new HashSet<AppProduct>();
            AppTemplateConversionUnitAppUnitIdSinceNavigations = new HashSet<AppTemplateConversionUnit>();
            AppTemplateConversionUnitAppUnitIdUntilNavigations = new HashSet<AppTemplateConversionUnit>();
            AppUnitsofMeasureforIngredients = new HashSet<AppUnitsofMeasureforIngredient>();
            AppUnitsofMeasureforMaterials = new HashSet<AppUnitsofMeasureforMaterial>();
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

        public virtual ICollection<AppDetailQuote> AppDetailQuotes { get; set; }
        public virtual ICollection<AppProduct> AppProductAppUnits { get; set; }
        public virtual ICollection<AppProductConversion> AppProductConversionAppUnitsIdAlternativaNavigations { get; set; }
        public virtual ICollection<AppProductConversion> AppProductConversionAppUnitsIdBaseNavigations { get; set; }
        public virtual ICollection<AppProduct> AppProductProductionUnits { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdSinceNavigations { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnitAppUnitIdUntilNavigations { get; set; }
        public virtual ICollection<AppUnitsofMeasureforIngredient> AppUnitsofMeasureforIngredients { get; set; }
        public virtual ICollection<AppUnitsofMeasureforMaterial> AppUnitsofMeasureforMaterials { get; set; }
    }
}
