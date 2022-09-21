using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req010
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public byte IdRuta { get; set; }

        public virtual Wity021 IdUsuarioNavigation { get; set; }
    }
}
