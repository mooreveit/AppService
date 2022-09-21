using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req013
    {
        public int Id { get; set; }
        public long IdRequerimiento { get; set; }
        public short IdCampo { get; set; }
        public string Valor { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
