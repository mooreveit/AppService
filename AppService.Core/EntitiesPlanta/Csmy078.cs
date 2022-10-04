using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Csmy078
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long JobNo { get; set; }
        public long Cantidad { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string FlagActualizad { get; set; }
    }
}
