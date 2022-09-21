using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class RechazosA
    {
        public string NumCot { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaPasada { get; set; }
        public DateTime? FecAproCob { get; set; }
        public DateTime? FechaAprobCont { get; set; }
        public DateTime? FecAproP { get; set; }
        public decimal? TipoProduct { get; set; }
        public string EstacionR { get; set; }
    }
}
