using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy617
    {
        public decimal Id { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string DescripcionSubCategoria { get; set; }
        public decimal? MillaresDesde { get; set; }
        public decimal? MillaresHasta { get; set; }
        public decimal? CantTintasDesde { get; set; }
        public decimal? CantTintasHasta { get; set; }
        public string TituloMillares { get; set; }
        public string TituloTintas { get; set; }
        public decimal? CantTirasDesde { get; set; }
        public decimal? CantTirasHasta { get; set; }
        public decimal? TipoPapel { get; set; }
    }
}
