using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy655log
    {
        public decimal Recnum { get; set; }
        public long IdCalculo { get; set; }
        public short IdEstacion { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
    }
}
