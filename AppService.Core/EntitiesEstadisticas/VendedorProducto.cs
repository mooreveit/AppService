using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VendedorProducto
    {
        public string NombreVend { get; set; }
        public string NombreLinea { get; set; }
        public int? Parte { get; set; }
        public string TipoPapel { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Porcmc { get; set; }
        public decimal? Comision { get; set; }
        public string Concesion { get; set; }
        public decimal? Tabla { get; set; }
        public decimal? PorcComision { get; set; }
    }
}
