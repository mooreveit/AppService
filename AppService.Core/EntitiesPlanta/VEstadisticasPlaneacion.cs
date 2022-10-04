using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VEstadisticasPlaneacion
    {
        public long Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
    }
}
