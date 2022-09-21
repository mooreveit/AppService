using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy572
    {
        public long Id { get; set; }
        public long IdPrecio { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public decimal? Precio { get; set; }
        public string Inactivo { get; set; }
        public string Observaciones { get; set; }
        public int? IdModulo { get; set; }
    }
}
