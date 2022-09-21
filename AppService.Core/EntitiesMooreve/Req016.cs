using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req016
    {
        public long Id { get; set; }
        public long IdRequerimiento { get; set; }
        public string IdUsuario { get; set; }
        public string Estatus { get; set; }
        public byte Secuencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Observaciones { get; set; }
    }
}
