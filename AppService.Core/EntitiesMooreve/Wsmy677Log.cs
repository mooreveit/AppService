using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy677Log
    {
        public int IdExcepcion { get; set; }
        public string IdCliente { get; set; }
        public decimal PorcComision { get; set; }
        public bool FlagEliminada { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Accion { get; set; }
    }
}
