using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class SegUsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }

        public virtual SegRol IdRolNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
