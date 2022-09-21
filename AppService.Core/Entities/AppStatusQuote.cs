// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.AppStatusQuote
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class AppStatusQuote
    {
        public AppStatusQuote()
        {
            this.AppDetailQuotes = (ICollection<AppService.Core.Entities.AppDetailQuotes>)new HashSet<AppService.Core.Entities.AppDetailQuotes>();
            this.AppGeneralQuotes = (ICollection<AppService.Core.Entities.AppGeneralQuotes>)new HashSet<AppService.Core.Entities.AppGeneralQuotes>();
        }

        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string ClaseCss { get; set; }

        public string FlagGanada { get; set; }

        public string FlagModificar { get; set; }

        public string FlagActiva { get; set; }

        public string FlagPostergada { get; set; }

        public string FlagPerdida { get; set; }

        public string FlagCaducada { get; set; }

        public string FlagEnEspera { get; set; }

        public string FlagCaducaInactiva { get; set; }

        public string Abreviado { get; set; }

        public string PrimeraEstacion { get; set; }

        public Decimal? CondicionRazonId { get; set; }

        public string OdooStatus { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppDetailQuotes> AppDetailQuotes { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppGeneralQuotes> AppGeneralQuotes { get; set; }
    }
}
