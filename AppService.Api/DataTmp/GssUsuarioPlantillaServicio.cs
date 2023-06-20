using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssUsuarioPlantillaServicio
    {
        public int IdUsuarioPlantillaServicio { get; set; }
        public int IdUsuario { get; set; }
        public int IdServicio { get; set; }
        public int IdVariable { get; set; }

        public virtual GssServicio IdServicioNavigation { get; set; }
        public virtual GssVariable IdVariableNavigation { get; set; }
    }
}
