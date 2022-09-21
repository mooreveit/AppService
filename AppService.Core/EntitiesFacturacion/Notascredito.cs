using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Notascredito
    {
        public string TipoProducto { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public string SumaResta { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public DateTime Hora { get; set; }
        public int Campo { get; set; }
        public decimal? Cambio { get; set; }
    }
}
