using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req017
    {
        public long Id { get; set; }
        public long IdLog { get; set; }
        public long IdRequerimiento { get; set; }
        public string IdUsuario { get; set; }
        public string Estatus { get; set; }
        public byte Secuencia { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
