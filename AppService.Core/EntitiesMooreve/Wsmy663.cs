using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy663
    {
        public decimal Recnum { get; set; }
        public long IdCalculo { get; set; }
        public short IdRuta { get; set; }
        public short IdEstacion { get; set; }
        public string IdUsuario { get; set; }
        public string IdEstatus { get; set; }
        public short Secuencia { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
    }
}
