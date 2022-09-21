using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry231
    {
        public int IdTripa { get; set; }
        public int IdSolicitud { get; set; }
        public short? PaginaDesde { get; set; }
        public short? PaginaHasta { get; set; }
        public bool? Tiro { get; set; }
        public bool? Retiro { get; set; }
        public string IdPapel { get; set; }
        public byte? IdBarniz { get; set; }
        public bool? BarnizTiro { get; set; }
        public bool? BarnizRetiro { get; set; }
        public bool? BarnizReserva { get; set; }
        public bool? BarnizRegistro { get; set; }

        public virtual Wpry229 IdSolicitudNavigation { get; set; }
    }
}
