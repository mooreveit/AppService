using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EjeucionProcesoVariacionInventario
    {
        public decimal Id { get; set; }
        public decimal? FechaJuliana { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Usuario { get; set; }
    }
}
