using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// Usuario por niveles de servicio
    /// </summary>
    public partial class GssUsuarioNivel
    {
        public int IdUsuarioNivel { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public int IdNivel { get; set; }
        public int Secuencia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }

        public virtual GssNivel IdNivelNavigation { get; set; }
    }
}
