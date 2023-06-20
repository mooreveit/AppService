using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Registro Solicitud de Servicio
    /// </summary>
    public partial class GssSolicitud
    {
        public GssSolicitud()
        {
            GssPasoSolicituds = new HashSet<GssPasoSolicitud>();
            GssTareas = new HashSet<GssTarea>();
        }

        public long IdSolicitud { get; set; }
        public string TituloSolicitud { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string JustificacionSolicitud { get; set; }
        public short IdUnidadServicio { get; set; }
        public short IdEstatusSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssEstatusSolicitud IdEstatusSolicitudNavigation { get; set; }
        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
        public virtual ICollection<GssPasoSolicitud> GssPasoSolicituds { get; set; }
        public virtual ICollection<GssTarea> GssTareas { get; set; }
    }
}
