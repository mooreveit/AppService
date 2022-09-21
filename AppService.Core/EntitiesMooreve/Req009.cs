using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req009
    {
        public int Id { get; set; }
        public int IdRutaAprobacion { get; set; }
        public byte IdRuta { get; set; }
        public string IdUsuario { get; set; }
        public byte Secuencia { get; set; }

        public virtual Wity021 IdUsuarioNavigation { get; set; }
    }
}
