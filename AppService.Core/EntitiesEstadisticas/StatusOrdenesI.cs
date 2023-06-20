using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class StatusOrdenesI
    {
        public decimal? Orden { get; set; }
        public string Cliente { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
