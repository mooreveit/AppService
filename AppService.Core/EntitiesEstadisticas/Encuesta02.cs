using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Encuesta02
    {
        public decimal? CodOficina { get; set; }
        public string NomOficina { get; set; }
        public decimal? ClienteDespacho { get; set; }
        public decimal? ClienteEncuesta { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
    }
}
