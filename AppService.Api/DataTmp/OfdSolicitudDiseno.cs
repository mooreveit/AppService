using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdSolicitudDiseno
    {
        public OfdSolicitudDiseno()
        {
            OfdAdjuntosDisenos = new HashSet<OfdAdjuntosDiseno>();
            OfdDetalleSolicitudDisenos = new HashSet<OfdDetalleSolicitudDiseno>();
            OfdSeguimientos = new HashSet<OfdSeguimiento>();
            OfdSolicitudDisenoCambios = new HashSet<OfdSolicitudDisenoCambio>();
            OfdVoBoDisenos = new HashSet<OfdVoBoDiseno>();
        }

        public long IdSolicitud { get; set; }
        public long IdPropuesta { get; set; }
        public string IdPieImprenta { get; set; }
        public short IdTipoRespaldo { get; set; }
        public short UbicacionMarginal { get; set; }
        public bool FlagCambioParte { get; set; }
        public string ObsvSolicitud { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioActivo { get; set; }
        public string IdTipoCambio { get; set; }

        public virtual OfdMaestroPieImprentum IdPieImprentaNavigation { get; set; }
        public virtual OfdPropuestum IdPropuestaNavigation { get; set; }
        public virtual OfdTipoCambioDiseno IdTipoCambioNavigation { get; set; }
        public virtual OfdMaestroTipoRespaldo IdTipoRespaldoNavigation { get; set; }
        public virtual OfdMaestroUbicacionMarginal UbicacionMarginalNavigation { get; set; }
        public virtual OfdAprobacionDiseno OfdAprobacionDiseno { get; set; }
        public virtual ICollection<OfdAdjuntosDiseno> OfdAdjuntosDisenos { get; set; }
        public virtual ICollection<OfdDetalleSolicitudDiseno> OfdDetalleSolicitudDisenos { get; set; }
        public virtual ICollection<OfdSeguimiento> OfdSeguimientos { get; set; }
        public virtual ICollection<OfdSolicitudDisenoCambio> OfdSolicitudDisenoCambios { get; set; }
        public virtual ICollection<OfdVoBoDiseno> OfdVoBoDisenos { get; set; }
    }
}
