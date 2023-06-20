using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class EstadisticasWebVendedor
    {
        public string Vendedor { get; set; }
        public string Nombre { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Descripcion { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
    }
}
