using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy454
    {
        public int Recnum { get; set; }
        public int? RecOrigen { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Costos { get; set; }
        public decimal? PorAfecta { get; set; }
        public int? RecOficina { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? Rcostos { get; set; }
        public decimal? RvalorLista { get; set; }

        public virtual Wsmy453 RecOficinaNavigation { get; set; }
    }
}
