using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppIngredient
    {
        public AppIngredient()
        {
            AppRecipes = new HashSet<AppRecipe>();
            AppRecipesByAppDetailQuotes = new HashSet<AppRecipesByAppDetailQuote>();
            AppUnitsofMeasureforIngredients = new HashSet<AppUnitsofMeasureforIngredient>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int AppUnitId { get; set; }
        public decimal Cost { get; set; }
        public long? PrymaryMtrMonedaId { get; set; }
        public long? SecundaryMtrMonedaId { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual MtrTipoMonedum PrymaryMtrMoneda { get; set; }
        public virtual MtrTipoMonedum SecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppRecipe> AppRecipes { get; set; }
        public virtual ICollection<AppRecipesByAppDetailQuote> AppRecipesByAppDetailQuotes { get; set; }
        public virtual ICollection<AppUnitsofMeasureforIngredient> AppUnitsofMeasureforIngredients { get; set; }
    }
}
