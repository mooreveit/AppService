using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssUsuarioCompañium
    {
        public int IdUsuarioCompañia { get; set; }
        public int IdUsuario { get; set; }
        public short IdCompañia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssCompañium IdCompañiaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
