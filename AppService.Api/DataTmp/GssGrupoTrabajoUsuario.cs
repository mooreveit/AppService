using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssGrupoTrabajoUsuario
    {
        public int IdGrupoTrabajoUsuario { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public int Secuencia { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }
    }
}
