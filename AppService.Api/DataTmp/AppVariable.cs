using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppVariable
    {
        public AppVariable()
        {
            AppDetailQuotesConversionUnits = new HashSet<AppDetailQuotesConversionUnit>();
            AppProductVariableSearchTexts = new HashSet<AppProductVariableSearchText>();
            AppRecipes = new HashSet<AppRecipe>();
            AppRecipesByAppDetailQuotes = new HashSet<AppRecipesByAppDetailQuote>();
            AppTemplateConversionUnits = new HashSet<AppTemplateConversionUnit>();
            AppVariableSearches = new HashSet<AppVariableSearch>();
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

        public virtual ICollection<AppDetailQuotesConversionUnit> AppDetailQuotesConversionUnits { get; set; }
        public virtual ICollection<AppProductVariableSearchText> AppProductVariableSearchTexts { get; set; }
        public virtual ICollection<AppRecipe> AppRecipes { get; set; }
        public virtual ICollection<AppRecipesByAppDetailQuote> AppRecipesByAppDetailQuotes { get; set; }
        public virtual ICollection<AppTemplateConversionUnit> AppTemplateConversionUnits { get; set; }
        public virtual ICollection<AppVariableSearch> AppVariableSearches { get; set; }
    }
}
