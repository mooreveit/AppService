using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaHistoricoDeMensajesPorIdCalculo
    {
        public decimal IdSolicitud { get; set; }
        public string Orden { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Fecha { get; set; }
        public string TipoProceso { get; set; }
    }
}
