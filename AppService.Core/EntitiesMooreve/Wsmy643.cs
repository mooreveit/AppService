using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy643
    {
        public decimal Recnum { get; set; }
        public decimal MillaresHasta { get; set; }
        public short TintasHasta { get; set; }
        public int IdCategoria { get; set; }
        public short IdCategoriaMc { get; set; }
        public bool FlagTransfer { get; set; }
        public decimal PorMcFinan { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
