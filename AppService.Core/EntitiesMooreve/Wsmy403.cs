using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy403
    {
        public decimal IdControl { get; set; }
        public decimal MesCon { get; set; }
        public decimal AnoCon { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string Cerrado { get; set; }
    }
}
