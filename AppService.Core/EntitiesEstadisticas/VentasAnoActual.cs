using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasAnoActual
    {
        public string Vendedor { get; set; }
        public decimal? Venta { get; set; }
        public decimal? CantOrdenes { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
    }
}
