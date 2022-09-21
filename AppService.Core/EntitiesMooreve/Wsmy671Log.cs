using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy671Log
    {
        public decimal Recnum { get; set; }
        public decimal PorcDeduccion { get; set; }
        public short DiasCobranzaDesde { get; set; }
        public short DiasCobranzaHasta { get; set; }
        public short IdTipoNegocio { get; set; }
        public string UsuarioCrea { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string Accion { get; set; }
    }
}
