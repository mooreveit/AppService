using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class HistoricoAcumVenta
    {
        public string Vendedor { get; set; }
        public decimal? Ventas { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Costo { get; set; }
    }
}
