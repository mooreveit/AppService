using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry241
    {
        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdParte { get; set; }
        public short IdUbicacion { get; set; }
        public string IdTinta { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Wsmy501 CotizacionNavigation { get; set; }
        public virtual Wpry240 Wpry240 { get; set; }
    }
}
