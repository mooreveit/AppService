using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EjeucionProceso
    {
        public decimal Id { get; set; }
        public decimal? IdEvaluacion { get; set; }
        public string Query { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaEjecucion { get; set; }
    }
}
