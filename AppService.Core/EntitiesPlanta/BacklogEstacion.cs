using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class BacklogEstacion
    {
        public long Orden { get; set; }
        public long JobId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estacion { get; set; }
    }
}
