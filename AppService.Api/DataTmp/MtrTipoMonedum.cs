using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrTipoMonedum
    {
        public MtrTipoMonedum()
        {
            AppGeneralQuotes = new HashSet<AppGeneralQuote>();
            AppIngredientPrymaryMtrMoneda = new HashSet<AppIngredient>();
            AppIngredientSecundaryMtrMoneda = new HashSet<AppIngredient>();
            AppProductPrymaryMtrMoneda = new HashSet<AppProduct>();
            AppProductSecundaryMtrMoneda = new HashSet<AppProduct>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string OdooId { get; set; }

        public virtual ICollection<AppGeneralQuote> AppGeneralQuotes { get; set; }
        public virtual ICollection<AppIngredient> AppIngredientPrymaryMtrMoneda { get; set; }
        public virtual ICollection<AppIngredient> AppIngredientSecundaryMtrMoneda { get; set; }
        public virtual ICollection<AppProduct> AppProductPrymaryMtrMoneda { get; set; }
        public virtual ICollection<AppProduct> AppProductSecundaryMtrMoneda { get; set; }
    }
}
