using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class EstadisticasOficina
    {
        public decimal Id { get; set; }
        public string Oficina { get; set; }
        public string VentasUsd { get; set; }
        public string CuotasUsd { get; set; }
        public string Cumplimiento { get; set; }
        public string Pies2 { get; set; }
        public string UsdPies2 { get; set; }
        public string Kgs { get; set; }
        public decimal? Ventas { get; set; }
        public decimal? Cuotas { get; set; }
        public decimal? Cumplimientos { get; set; }
        public decimal? PiesCuadrados { get; set; }
        public decimal? UsdPiesCuadrados { get; set; }
        public decimal? Kilogramos { get; set; }
        public decimal? EstacionCxc { get; set; }
        public string EstacionCxc1 { get; set; }
        public decimal? EstacionPlanta { get; set; }
        public string EstacionPlanta1 { get; set; }
    }
}
