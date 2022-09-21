using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class TotalXOrden2
    {
        public int? DiasP { get; set; }
        public int? HorasP { get; set; }
        public string Vend { get; set; }
        public DateTime? Grabada { get; set; }
        public decimal Cotizacion { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public double? Millares { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Conc { get; set; }
        public decimal? ListaDol { get; set; }
        public decimal? VentaDol { get; set; }
        public string Estado { get; set; }
    }
}
