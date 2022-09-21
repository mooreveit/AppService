using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy440
    {
        public int IdOficina { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Costos { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? Rcostos { get; set; }
        public decimal? RvalorLista { get; set; }
    }
}
