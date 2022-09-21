using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class TabulaDespMc
    {
        public decimal Id { get; set; }
        public decimal? MillarDesde { get; set; }
        public decimal? MillarHasta { get; set; }
        public decimal? Factor0C { get; set; }
        public decimal? Factor1C { get; set; }
        public decimal? Factor2C { get; set; }
        public decimal? Factor3C { get; set; }
        public decimal? Factor4C { get; set; }
    }
}
