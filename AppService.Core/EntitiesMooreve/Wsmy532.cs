using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy532
    {
        public int Id { get; set; }
        public string Compañia { get; set; }
        public string TipoLibro { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public byte Forecast { get; set; }
        public string Usuario { get; set; }
        public string Nombreusuario { get; set; }
        public int? Rol { get; set; }
        public string NombreRol { get; set; }
        public string UsuarioRed { get; set; }
        public string EquipoRed { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Act { get; set; }

        public virtual Wsmy527 ForecastNavigation { get; set; }
        public virtual Wsmy535 MesNavigation { get; set; }
        public virtual Wsmy528 TipoLibroNavigation { get; set; }
    }
}
