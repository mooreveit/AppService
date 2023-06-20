using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdSolicitudDisenoCambio
    {
        public long IdSolDisCam { get; set; }
        public long IdSolicitud { get; set; }
        public int IdCambio { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdCambioDiseno IdCambioNavigation { get; set; }
        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
