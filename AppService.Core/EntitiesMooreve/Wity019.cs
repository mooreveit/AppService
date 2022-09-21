using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity019
    {
        public string IdEmpresa { get; set; }
        public int IdPrograma { get; set; }
        public string IdUsuario { get; set; }
        public string FlagEliminado { get; set; }
        public string FlagGeneral { get; set; }

        public virtual Wity018 IdEmpresaNavigation { get; set; }
        public virtual Wity021 IdUsuarioNavigation { get; set; }
    }
}
