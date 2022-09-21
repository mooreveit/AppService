using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req022
    {
        public byte Id { get; set; }
        public byte IdLimiteRequerimientosUsuario { get; set; }
        public string IdUsuario { get; set; }
        public byte LimiteRequerimientos { get; set; }
    }
}
