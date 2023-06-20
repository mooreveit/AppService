using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TempReciboCobro
    {
        public decimal Recnum { get; set; }
        public long Documento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
