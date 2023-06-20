using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasPorRegion
    {
        public string RegionVta { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Ventas { get; set; }
    }
}
