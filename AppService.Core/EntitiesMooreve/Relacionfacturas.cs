using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Relacionfacturas
    {
        public DateTime FechaFactura { get; set; }
        public int Factura { get; set; }
        public decimal? Remision { get; set; }
        public string Cliente { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Impuesto { get; set; }
        public decimal? Concesion { get; set; }
        public long Orden { get; set; }
        public string CondicionPago { get; set; }
        public string Oficina { get; set; }
        public decimal? TotalFactura { get; set; }
        public string Miscelaneo { get; set; }
    }
}
