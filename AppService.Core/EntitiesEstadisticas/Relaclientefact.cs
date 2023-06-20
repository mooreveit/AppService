using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Relaclientefact
    {
        public decimal? Factura { get; set; }
        public decimal? Cliente { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string Anulada { get; set; }
        public decimal? MesFactura { get; set; }
        public decimal? AnoFactura { get; set; }
    }
}
