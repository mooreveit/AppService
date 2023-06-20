using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Registro de Tareas por Solicitud
    /// </summary>
    public partial class GssTarea
    {
        public GssTarea()
        {
            GssAdjuntoTareas = new HashSet<GssAdjuntoTarea>();
            GssAprobacionServicios = new HashSet<GssAprobacionServicio>();
            GssTareaComentarios = new HashSet<GssTareaComentario>();
            GssTareaPlantillaServicios = new HashSet<GssTareaPlantillaServicio>();
        }

        public long IdTarea { get; set; }
        public DateTime FechaTarea { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaProcesada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int IdServicio { get; set; }
        public long IdSolicitud { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssServicio IdServicioNavigation { get; set; }
        public virtual GssSolicitud IdSolicitudNavigation { get; set; }
        public virtual ICollection<GssAdjuntoTarea> GssAdjuntoTareas { get; set; }
        public virtual ICollection<GssAprobacionServicio> GssAprobacionServicios { get; set; }
        public virtual ICollection<GssTareaComentario> GssTareaComentarios { get; set; }
        public virtual ICollection<GssTareaPlantillaServicio> GssTareaPlantillaServicios { get; set; }
    }
}
