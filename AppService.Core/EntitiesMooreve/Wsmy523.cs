using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy523
    {
        public long Id { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public int? Rol { get; set; }
        public string NombreRol { get; set; }
        public string UsuarioRed { get; set; }
        public string EquipoRed { get; set; }
    }
}
