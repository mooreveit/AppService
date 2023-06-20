using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VBacklog
    {
        public string Vendedor { get; set; }
        public long Orden { get; set; }
        public string NomVendedor { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? RtotalVenta { get; set; }
        public string Cliente { get; set; }
        public string CodProducto { get; set; }
        public long? Cantidad { get; set; }
        public decimal? Precioventa { get; set; }
        public decimal? Rprecioventa { get; set; }
    }
}
