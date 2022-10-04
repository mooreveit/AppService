using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class QueryEstadisticas01
    {
        public decimal? Orden { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
    }
}
