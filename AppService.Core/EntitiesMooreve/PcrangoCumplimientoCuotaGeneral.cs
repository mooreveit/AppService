using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PcrangoCumplimientoCuotaGeneral
    {
        public int Id { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? PorcentajeGerente { get; set; }
    }
}
