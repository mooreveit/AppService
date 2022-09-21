using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy631
    {
        public long Recnum { get; set; }
        public long Id { get; set; }
        public short IdCalendarioGeneral { get; set; }
        public short IdCalendarioDetalle { get; set; }
        public string IdVariable { get; set; }
        public string Valor { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
