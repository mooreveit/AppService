using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Wpry062
    {
        public int? RecordNumber { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public DateTime? FechaAct { get; set; }
        public string Persona { get; set; }
        public decimal? CodAnulacion { get; set; }
        public decimal? NroAnulacion { get; set; }
        public string Observacion1 { get; set; }
        public string Observacion2 { get; set; }
        public string Tipo { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
    }
}
