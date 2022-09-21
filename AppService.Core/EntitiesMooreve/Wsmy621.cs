using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy621
    {
        public int IdClausula { get; set; }
        public string Clausula { get; set; }
        public int Orden { get; set; }
        public DateTime FechaVigencia { get; set; }
        public DateTime FechaCaduca { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
