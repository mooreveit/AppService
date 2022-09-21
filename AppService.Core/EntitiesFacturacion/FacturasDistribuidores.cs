using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class FacturasDistribuidores
    {
        public decimal Id { get; set; }
        public int Factura { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
