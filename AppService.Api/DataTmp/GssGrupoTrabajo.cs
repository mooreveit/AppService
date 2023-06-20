using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssGrupoTrabajo
    {
        public int IdGrupoTabajo { get; set; }
        public string NombreGrupoTrabajo { get; set; }
        public int? IdUnidadServicio { get; set; }
        public DateTime FechaCambio { get; set; }
        public int UsuarioCambio { get; set; }
    }
}
