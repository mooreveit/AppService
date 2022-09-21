using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwPronosticoDiarioCia
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? DiaHabil { get; set; }
        public decimal? Cobrado { get; set; }
        public decimal? EstimadoTotal { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? EstimadoDiario { get; set; }
        public decimal? CobradoAcumulado { get; set; }
        public decimal? EstimadoAcumulado { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? CobradoSinPosteo { get; set; }
        public decimal? CobradoAcumuladoSinPosteo { get; set; }
    }
}
