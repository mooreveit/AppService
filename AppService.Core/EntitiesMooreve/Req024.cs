using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req024
    {
        public long Id { get; set; }
        public long IdBackLog { get; set; }
        public string IdUsuario { get; set; }
        public long IdRequerimiento { get; set; }
        public byte Secuencia { get; set; }
        public string FlagCulminado { get; set; }
    }
}
