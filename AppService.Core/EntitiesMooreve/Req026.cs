using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req026
    {
        public long Id { get; set; }
        public long IdDetalleAprobacion { get; set; }
        public long IdRequerimiento { get; set; }
        public string IdUsuario { get; set; }
        public string Estatus { get; set; }
        public byte Secuencia { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Observaciones { get; set; }
    }
}
