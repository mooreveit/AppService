using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy389
    {
        public decimal Id { get; set; }
        public decimal Codigo { get; set; }
        public string Cliente { get; set; }
        public string Rif { get; set; }
        public string Descripcion { get; set; }
        public decimal? UltimaNumDesde { get; set; }
        public decimal? UltimaNumHasta { get; set; }
        public DateTime? FechaUltNum { get; set; }
        public string Cotizacion { get; set; }
        public decimal? Orden { get; set; }
        public int? NumCopy { get; set; }
        public string ClienteNuevo { get; set; }
    }
}
