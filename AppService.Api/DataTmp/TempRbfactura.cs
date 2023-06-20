using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TempRbfactura
    {
        public decimal Recnum { get; set; }
        public long DocRb { get; set; }
        public long Factura { get; set; }
        public DateTime Fecha { get; set; }
    }
}
