using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy619
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string DescripcionSubCategoria { get; set; }
        public decimal? MillaresDesde { get; set; }
        public decimal? MillaresHasta { get; set; }
        public decimal? CantTintasDesde { get; set; }
        public decimal? CantTintasHasta { get; set; }
        public decimal? BsMc { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? PorcMc { get; set; }
        public string TituloMillares { get; set; }
        public string TituloTintas { get; set; }
        public string Origen { get; set; }
        public decimal? RbsMc { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
