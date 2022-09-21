using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy650
    {
        public decimal Recnum { get; set; }
        public short IdEstacion { get; set; }
        public string Abreviado { get; set; }
        public string NombreEstacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public bool FlagVolumen { get; set; }
    }
}
