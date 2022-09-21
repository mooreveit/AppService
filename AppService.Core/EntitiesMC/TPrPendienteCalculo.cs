using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPrPendienteCalculo
    {
        public decimal Id { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Culminado { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
    }
}
