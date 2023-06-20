using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdTintasCotizacion
    {
        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public int IdParte { get; set; }
        public short IdUbicacion { get; set; }
        public string IdTinta { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
