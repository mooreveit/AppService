using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class QueryOpCeo
    {
        public string Codigo { get; set; }
        public decimal Cotizacion { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public double? PorFacturar { get; set; }
        public double? Venta { get; set; }
        public double? Lista { get; set; }
        public double? Concesion { get; set; }
    }
}
