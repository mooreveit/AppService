using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class QueryOpImp
    {
        public int Codigo { get; set; }
        public long Orden { get; set; }
        public decimal? PorFacturar { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Concesion { get; set; }
    }
}
