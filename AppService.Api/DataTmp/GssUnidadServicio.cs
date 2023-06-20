using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Unidad de Servicio por Compañia   (Dpto.) 
    /// </summary>
    public partial class GssUnidadServicio
    {
        public GssUnidadServicio()
        {
            GssAreaServicios = new HashSet<GssAreaServicio>();
            GssNivels = new HashSet<GssNivel>();
            GssSolicituds = new HashSet<GssSolicitud>();
            GssUnidadServicioCompañia = new HashSet<GssUnidadServicioCompañium>();
        }

        public short IdUnidadServicio { get; set; }
        public string NombreUnidadServicio { get; set; }
        public string Abreviado { get; set; }
        public bool Activo { get; set; }
        public string CuentaUnidadServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual ICollection<GssAreaServicio> GssAreaServicios { get; set; }
        public virtual ICollection<GssNivel> GssNivels { get; set; }
        public virtual ICollection<GssSolicitud> GssSolicituds { get; set; }
        public virtual ICollection<GssUnidadServicioCompañium> GssUnidadServicioCompañia { get; set; }
    }
}
