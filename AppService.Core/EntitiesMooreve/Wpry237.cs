using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry237
    {
        public int IdRol { get; set; }
        public string IdEstatus { get; set; }
        public bool? PermiteAgregar { get; set; }
        public bool? PermiteModificar { get; set; }
        public bool? PermiteEliminar { get; set; }
        public bool? PermiteEnviar { get; set; }
        public bool? PermiteAprobar { get; set; }
        public bool? PermiteRechazar { get; set; }
        public bool? PermiteDevolver { get; set; }
        public bool? PermiteStatus { get; set; }
        public bool? PermiteReporte { get; set; }
    }
}
