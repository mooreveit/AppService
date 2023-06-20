using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssPasoSolicitud
    {
        public short IdPasoSolicitud { get; set; }
        public long IdSolicitud { get; set; }
        public bool DatosGenerales { get; set; }
        public bool TareasServicios { get; set; }
        public bool CamposAdicionales { get; set; }
        public bool AdjuntosObservaciones { get; set; }

        public virtual GssSolicitud IdSolicitudNavigation { get; set; }
    }
}
