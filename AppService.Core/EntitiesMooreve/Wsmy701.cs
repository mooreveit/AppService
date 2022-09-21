using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy701
    {
        public decimal Id { get; set; }
        public decimal PuntosDesde { get; set; }
        public decimal PuntosHasta { get; set; }
        public decimal PorcentajePagar { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
    }
}
