using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumosPorCodigoDiario
    {
        public DateTime? FechaTransac { get; set; }
        public string Codigo { get; set; }
        public decimal? Kilos { get; set; }
    }
}
