using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class FacturasxClientes01
    {
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public decimal? Factura { get; set; }
        public DateTime? FechaFactura { get; set; }
    }
}
