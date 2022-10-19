using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumosPorCodigoYAnchosDiario
    {
        public DateTime? FechaTransac { get; set; }
        public string Codigo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Kilos { get; set; }
    }
}
