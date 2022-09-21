using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class RechazosCeos
    {
        public decimal? NumCot { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
    }
}
