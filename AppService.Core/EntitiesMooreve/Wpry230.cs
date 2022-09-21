using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry230
    {
        public int Recnum { get; set; }
        public int IdSolicitud { get; set; }
        public long OrdenHija { get; set; }
        public decimal CotizacionHija { get; set; }
    }
}
