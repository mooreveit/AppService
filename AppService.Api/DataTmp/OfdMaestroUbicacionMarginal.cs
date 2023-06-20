using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdMaestroUbicacionMarginal
    {
        public OfdMaestroUbicacionMarginal()
        {
            OfdSolicitudDisenos = new HashSet<OfdSolicitudDiseno>();
        }

        public short IdUbicacionMarginal { get; set; }
        public string UbicacionMarginal { get; set; }

        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDisenos { get; set; }
    }
}
