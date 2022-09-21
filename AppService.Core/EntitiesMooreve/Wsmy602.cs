using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy602
    {
        public long IdRegistro { get; set; }
        public long IdDetalleAprobacion { get; set; }
        public long IdPrelista { get; set; }
        public string IdUsuario { get; set; }
        public short IdEstatus { get; set; }
        public short Secuencia { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Observaciones { get; set; }
    }
}
