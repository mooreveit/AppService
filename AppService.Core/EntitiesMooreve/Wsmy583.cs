using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy583
    {
        public decimal Id { get; set; }
        public string Producto { get; set; }
        public string MedidaFraccion { get; set; }
        public string MedidaMascara { get; set; }
        public decimal? Frecuencia { get; set; }
        public decimal? MedidaDecimal { get; set; }
    }
}
