using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy637
    {
        public long Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public long Orden { get; set; }
        public int IdSubCatVoBo { get; set; }
        public bool Valor { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
