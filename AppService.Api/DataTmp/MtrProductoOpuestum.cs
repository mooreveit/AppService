using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrProductoOpuestum
    {
        public decimal Id { get; set; }
        public string Producto { get; set; }
        public string MedidaFraccion { get; set; }
        public string MedidaMascara { get; set; }
        public decimal? Frecuencia { get; set; }
    }
}
