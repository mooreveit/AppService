using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wapy201
    {
        public decimal Id { get; set; }
        public string Titulo { get; set; }
        public decimal? Alicuota { get; set; }
        public decimal? Base { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Ivaretenido { get; set; }
        public decimal? IvaretenidoTerceros { get; set; }
        public string TipoRegistro { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public decimal? Item1 { get; set; }
        public decimal? Item2 { get; set; }
        public decimal? Rbase { get; set; }
        public decimal? Riva { get; set; }
        public decimal? Rivaretenido { get; set; }
        public decimal? RivaretenidoTerceros { get; set; }
    }
}
