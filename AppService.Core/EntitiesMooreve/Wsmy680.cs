using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy680
    {
        public int IdExcepcion { get; set; }
        public long Orden { get; set; }
        public decimal PorcComision { get; set; }
        public bool FlagEliminada { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
