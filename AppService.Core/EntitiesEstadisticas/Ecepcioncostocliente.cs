using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Ecepcioncostocliente
    {
        public double? Cliente { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public string Producto { get; set; }
        public double? Costo { get; set; }
        public double? PComis { get; set; }
    }
}
