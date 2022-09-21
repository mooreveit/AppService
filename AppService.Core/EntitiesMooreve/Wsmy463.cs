using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy463
    {
        public int Recnum { get; set; }
        public int? RecVendedor { get; set; }
        public string Causa { get; set; }
        public string Subcausa { get; set; }
        public int? PorRes { get; set; }
        public decimal? Costo { get; set; }
        public int? Correlativo { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
    }
}
