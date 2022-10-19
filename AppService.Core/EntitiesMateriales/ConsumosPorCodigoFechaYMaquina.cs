using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumosPorCodigoFechaYMaquina
    {
        public DateTime? FechaTransac { get; set; }
        public string Codigo { get; set; }
        public string Ubicacion { get; set; }
        public decimal? Kilos { get; set; }
    }
}
