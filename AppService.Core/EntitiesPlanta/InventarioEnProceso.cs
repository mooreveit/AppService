using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class InventarioEnProceso
    {
        public decimal? Orden { get; set; }
        public decimal? Millares { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
    }
}
