using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VProgramaUsuarios
    {
        public int? IdUsuario { get; set; }
        public int? IdRol { get; set; }
        public int? IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public string LinkModulo { get; set; }
        public int? IndiceModulo { get; set; }
        public int? IdPrograma { get; set; }
        public string Usuario { get; set; }
        public string NombrePrograma { get; set; }
    }
}
