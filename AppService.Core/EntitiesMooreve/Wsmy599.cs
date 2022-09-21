using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy599
    {
        public short IdRegistro { get; set; }
        public short IdEstatus { get; set; }
        public string Descripcion { get; set; }
        public string Abreviado { get; set; }
        public string FlagEnviado { get; set; }
        public string FlagPendiente { get; set; }
        public string FlagAprobado { get; set; }
        public string FlagRechazado { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
    }
}
