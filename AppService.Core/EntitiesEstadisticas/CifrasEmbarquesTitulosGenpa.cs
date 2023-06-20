using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesTitulosGenpa
    {
        public string TipoProducto { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
        public string SumaResta { get; set; }
        public DateTime? FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string Hora { get; set; }
        public decimal? Campo { get; set; }
        public decimal? VentaReal { get; set; }
        public decimal? ListaReal { get; set; }
        public decimal? TasaDolar { get; set; }
        public decimal? VentaDol { get; set; }
        public decimal? ListaDol { get; set; }
    }
}
