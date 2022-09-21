using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy629
    {
        public decimal RecNum { get; set; }
        public long Id { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public string IdVariable { get; set; }
        public string Valor { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
