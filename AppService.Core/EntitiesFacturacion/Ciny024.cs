using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny024
    {
        public decimal Recnum { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int Factura { get; set; }
        public int Remision { get; set; }
        public string Cliente { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Concesion { get; set; }
        public long Orden { get; set; }
        public string CondicionPago { get; set; }
        public string Oficina { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public decimal TotalFactura { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? Rimpuesto { get; set; }
    }
}
