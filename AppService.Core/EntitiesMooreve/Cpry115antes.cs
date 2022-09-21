using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Cpry115antes
    {
        public int IdGrupoPapel { get; set; }
        public string CodGrupoPapel { get; set; }
        public string DescGrupoPapel { get; set; }
        public decimal? CostoPapel { get; set; }
        public decimal? CostoPapelMasAlto { get; set; }
        public decimal? RcostoPapel { get; set; }
        public decimal? RcostoPapelMasAlto { get; set; }
    }
}
