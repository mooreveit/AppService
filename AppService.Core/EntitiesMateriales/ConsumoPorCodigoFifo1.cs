using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumoPorCodigoFifo1
    {
        public DateTime? FechaTransac { get; set; }
        public string Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Ctainv { get; set; }
        public string Ctacon { get; set; }
    }
}
