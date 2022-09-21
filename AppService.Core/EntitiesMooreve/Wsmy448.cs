using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy448
    {
        public int Recnum { get; set; }
        public int? IdSubCategoria { get; set; }
        public string SubCategoria { get; set; }
        public int? IdCategoria { get; set; }
        public string Categoria { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? IdPrintNoPrint { get; set; }
    }
}
