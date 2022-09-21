using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl009
    {
        public string IdUsuarioHijo { get; set; }
        public string IdUsuarioPadre { get; set; }
        public int IdPais { get; set; }
        public string FlagEliminado { get; set; }

        public virtual Rcl003 IdPaisNavigation { get; set; }
    }
}
