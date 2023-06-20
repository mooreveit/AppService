using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Niveles por servicios
    /// </summary>
    public partial class GssServicioNivel
    {
        public int IdServicioNivel { get; set; }
        public int IdServicio { get; set; }
        public int IdNivel { get; set; }
        public short Secuencia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssNivel IdNivelNavigation { get; set; }
        public virtual GssServicio IdServicioNavigation { get; set; }
    }
}
