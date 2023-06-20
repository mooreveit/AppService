using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class StatusOrdenesStock
    {
        public decimal? Orden { get; set; }
        public string Cliente { get; set; }
        public decimal? ValorVenta { get; set; }
        public string CodigoVendedor { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
        public DateTime? Grabada { get; set; }
        public DateTime? Factura { get; set; }
        public DateTime? Entrega { get; set; }
    }
}
