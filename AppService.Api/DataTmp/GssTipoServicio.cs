using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Tipo de Servicio por Area / Unudad
    /// </summary>
    public partial class GssTipoServicio
    {
        public GssTipoServicio()
        {
            GssServicios = new HashSet<GssServicio>();
        }

        public int IdTipoServicio { get; set; }
        public string NombreTipoServicio { get; set; }
        public int IdAreaServicio { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssAreaServicio IdAreaServicioNavigation { get; set; }
        public virtual ICollection<GssServicio> GssServicios { get; set; }
    }
}
