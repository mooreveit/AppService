using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Areas de Servicio por Unidad (Dpto.)
    /// </summary>
    public partial class GssAreaServicio
    {
        public GssAreaServicio()
        {
            GssTipoServicios = new HashSet<GssTipoServicio>();
        }

        public int IdAreaServicio { get; set; }
        public string NombreAreaServicio { get; set; }
        public short IdUnidadServicio { get; set; }
        public bool Activo { get; set; }
        public short IdCoordinador { get; set; }
        public short IdAprobador { get; set; }
        public short IdAprobadorGerencia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssUnidadServicio IdUnidadServicioNavigation { get; set; }
        public virtual ICollection<GssTipoServicio> GssTipoServicios { get; set; }
    }
}
