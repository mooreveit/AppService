using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CreEjecutaAprobarCredito
    {
        public decimal? Id { get; set; }
        public string Cotizacion { get; set; }
        public string Usuario { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public long Recnum { get; set; }
    }
}
