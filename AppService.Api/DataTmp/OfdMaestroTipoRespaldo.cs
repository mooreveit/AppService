using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdMaestroTipoRespaldo
    {
        public OfdMaestroTipoRespaldo()
        {
            OfdSolicitudDisenos = new HashSet<OfdSolicitudDiseno>();
        }

        public short IdTipoRespaldo { get; set; }
        public string TipoRespaldo { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDisenos { get; set; }
    }
}
