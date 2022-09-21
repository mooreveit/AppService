using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy679
    {
        public decimal Recnum { get; set; }
        public int IdSubCategoria { get; set; }
        public DateTime VentaDesde { get; set; }
        public DateTime VentaHasta { get; set; }
        public DateTime VigenteHasta { get; set; }
        public decimal PorcFlat { get; set; }
        public bool? FlagEliminada { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
    }
}
