using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssUnidadServicioCompañium
    {
        public int IdUnidadServicioCompañia { get; set; }
        public short IdUnidadServicio { get; set; }
        public short IdCompañia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssCompañium IdCompañiaNavigation { get; set; }
        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
    }
}
