using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VUsuarioProgramaRol
    {
        public int IdPrograma { get; set; }
        public string NombrePrograma { get; set; }
        public int Idusuario { get; set; }
        public string NombreUsuario { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string Usuario { get; set; }
    }
}
