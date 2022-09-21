using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny035
    {
        public decimal Recnum { get; set; }
        public string TipoProducto { get; set; }
        public long Venta { get; set; }
        public long Lista { get; set; }
        public string SumaResta { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Hora { get; set; }
        public short Campo { get; set; }
        public decimal TasaDolar { get; set; }
    }
}
