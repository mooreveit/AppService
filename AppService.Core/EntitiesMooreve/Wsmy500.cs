using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy500
    {
        public string Producto { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal? FormasTotalesDisponibles { get; set; }
        public decimal? BsMcbase { get; set; }
        public decimal? RbsMcbase { get; set; }
    }
}
