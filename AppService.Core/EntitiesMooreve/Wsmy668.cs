using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy668
    {
        public decimal Id { get; set; }
        public int Factura { get; set; }
        public string Articulo { get; set; }
        public decimal Copy { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaFactura { get; set; }
        public int Remision { get; set; }
        public decimal Cantidad { get; set; }
        public long Orden { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Rventa { get; set; }
    }
}
