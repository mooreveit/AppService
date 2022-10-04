using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry215
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public string Planificacion { get; set; }
        public string SugerenciaPlan { get; set; }
        public string AtencionCte { get; set; }
        public string SugerenciaAten { get; set; }
        public string Despacho { get; set; }
        public string SugerenciaDesp { get; set; }
    }
}
