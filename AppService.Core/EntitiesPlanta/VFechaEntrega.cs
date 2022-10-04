using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VFechaEntrega
    {
        public long Orden { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
