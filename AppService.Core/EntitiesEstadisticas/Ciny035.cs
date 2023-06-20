using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Ciny035
    {
        public int? RecordNumber { get; set; }
        public string TipoProducto { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
        public string SumaResta { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Hora { get; set; }
        public decimal? Campo { get; set; }
        public decimal? TasaDolar { get; set; }
        public decimal? RtasaDolar { get; set; }
    }
}
