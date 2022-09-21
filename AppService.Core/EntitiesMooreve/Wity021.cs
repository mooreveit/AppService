using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity021
    {
        public Wity021()
        {
            Req009 = new HashSet<Req009>();
            Wity019 = new HashSet<Wity019>();
            Wsmy545 = new HashSet<Wsmy545>();
        }

        public int Idusuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Inactivo { get; set; }
        public DateTime? FechaCambio { get; set; }
        public int? ConteoExpira { get; set; }
        public decimal? Intentosfallidos { get; set; }
        public int? Idoficina { get; set; }
        public string Email { get; set; }
        public string Ficha { get; set; }
        public double? An8 { get; set; }
        public string UsuarioDominio { get; set; }
        public string FlagPersonalSistemas { get; set; }
        public string FlagAutomata { get; set; }
        public string ClaveOculta { get; set; }
        public string Telefono { get; set; }
        public string ClasificacionUsuario { get; set; }
        public string Imei1 { get; set; }
        public string EquipoImei1 { get; set; }
        public string Imei2 { get; set; }
        public string EquipoImei2 { get; set; }
        public string Imei3 { get; set; }
        public string EquipoImei3 { get; set; }

        public virtual Req010 Req010 { get; set; }
        public virtual ICollection<Req009> Req009 { get; set; }
        public virtual ICollection<Wity019> Wity019 { get; set; }
        public virtual ICollection<Wsmy545> Wsmy545 { get; set; }
    }
}
