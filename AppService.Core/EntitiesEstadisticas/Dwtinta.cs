using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Dwtinta
    {
        public decimal? Orden { get; set; }
        public decimal? CantTintas { get; set; }
        public string Color { get; set; }
        public string Maquina { get; set; }
    }
}
