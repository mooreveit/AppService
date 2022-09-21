// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrTipoMoneda
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class MtrTipoMoneda
    {
        public MtrTipoMoneda()
        {
            this.AppGeneralQuotes = (ICollection<AppService.Core.Entities.AppGeneralQuotes>)new HashSet<AppService.Core.Entities.AppGeneralQuotes>();
            this.AppIngredientsPrymaryMtrMoneda = (ICollection<AppIngredients>)new HashSet<AppIngredients>();
            this.AppIngredientsSecundaryMtrMoneda = (ICollection<AppIngredients>)new HashSet<AppIngredients>();
            this.AppProductsPrymaryMtrMoneda = (ICollection<AppProducts>)new HashSet<AppProducts>();
            this.AppProductsSecundaryMtrMoneda = (ICollection<AppProducts>)new HashSet<AppProducts>();
        }

        public long Id { get; set; }

        public string Descripcion { get; set; }
        public string OdooId { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppGeneralQuotes> AppGeneralQuotes { get; set; }

        public virtual ICollection<AppIngredients> AppIngredientsPrymaryMtrMoneda { get; set; }

        public virtual ICollection<AppIngredients> AppIngredientsSecundaryMtrMoneda { get; set; }

        public virtual ICollection<AppProducts> AppProductsPrymaryMtrMoneda { get; set; }

        public virtual ICollection<AppProducts> AppProductsSecundaryMtrMoneda { get; set; }
    }
}
