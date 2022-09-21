using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class ProductosMcCorrectos
    {
        public long Recnum { get; set; }
        public decimal Orden { get; set; }
        public string Producto { get; set; }
        public decimal? Mcb { get; set; }
        public decimal? Mcf { get; set; }
    }
}
