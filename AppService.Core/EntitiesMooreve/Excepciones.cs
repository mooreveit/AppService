using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Excepciones
    {
        public decimal Id { get; set; }
        public string CodPapel { get; set; }
        public DateTime? VigDesde { get; set; }
        public DateTime? VigHasta { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Rcosto { get; set; }
    }
}
