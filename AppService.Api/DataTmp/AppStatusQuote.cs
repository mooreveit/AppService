using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppStatusQuote
    {
        public AppStatusQuote()
        {
            AppDetailQuotes = new HashSet<AppDetailQuote>();
            AppGeneralQuotes = new HashSet<AppGeneralQuote>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
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
        public decimal? CondicionRazonId { get; set; }
        public string ClaseCss { get; set; }
        public string OdooStatus { get; set; }

        public virtual ICollection<AppDetailQuote> AppDetailQuotes { get; set; }
        public virtual ICollection<AppGeneralQuote> AppGeneralQuotes { get; set; }
    }
}
