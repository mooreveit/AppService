using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class TemporalLc
    {
        public decimal? Cliente { get; set; }
        public decimal? Orden { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
