using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy677
    {
        public int IdExcepcion { get; set; }
        public string IdCliente { get; set; }
        public decimal PorcComision { get; set; }
        public bool FlagEliminada { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
