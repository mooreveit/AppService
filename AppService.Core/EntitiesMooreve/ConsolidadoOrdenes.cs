using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class ConsolidadoOrdenes
    {
        public int? Oficina { get; set; }
        public string NombreOficina { get; set; }
        public string NumCot { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Estacion { get; set; }
        public decimal? Venta { get; set; }
    }
}
