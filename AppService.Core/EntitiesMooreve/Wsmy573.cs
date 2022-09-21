using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy573
    {
        public long Id { get; set; }
        public long Idexcepcion { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PorcentajeAumento { get; set; }
        public string Todos { get; set; }
        public string Inactivo { get; set; }
        public string Observaciones { get; set; }
        public int? IdModulo { get; set; }
    }
}
