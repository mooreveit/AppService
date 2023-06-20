using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Especiale
    {
        public string Orden { get; set; }
        public double? Monto { get; set; }
        public string Calculartintas { get; set; }
        public string Calcularcajascartones { get; set; }
        public int? Montokg { get; set; }
    }
}
