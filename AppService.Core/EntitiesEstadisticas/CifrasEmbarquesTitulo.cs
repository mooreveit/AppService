using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesTitulo
    {
        public string TipoProducto { get; set; }
        public long Venta { get; set; }
        public long Lista { get; set; }
        public string SumaResta { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Hora { get; set; }
        public short Campo { get; set; }
        public long? VentaReal { get; set; }
        public long? ListaReal { get; set; }
        public decimal TasaDolar { get; set; }
        public decimal? VentaDol { get; set; }
        public decimal? ListaDol { get; set; }
    }
}
