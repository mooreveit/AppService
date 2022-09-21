using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DiasProvision
    {
        public decimal Id { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? PorcerntajeProvision { get; set; }
        public string TiluloPorcentaje { get; set; }
        public string TituloDias { get; set; }
    }
}
