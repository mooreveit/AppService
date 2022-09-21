using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl008
    {
        public string IdUsuario { get; set; }
        public string IdProceso { get; set; }
        public string IdEmpresa { get; set; }
        public string FlagEliminado { get; set; }

        public virtual Rcl002 IdEmpresaNavigation { get; set; }
        public virtual Rcl010 IdProcesoNavigation { get; set; }
    }
}
