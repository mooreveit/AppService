using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class FmXProducto
    {
        public string NombreLinea { get; set; }
        public int? Parte { get; set; }
        public string TipoPapel { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? Porcmc { get; set; }
    }
}
