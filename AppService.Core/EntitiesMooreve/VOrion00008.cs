using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VOrion00008
    {
        public string CodLista { get; set; }
        public string CodEvento { get; set; }
        public string CodSubEvento { get; set; }
        public string DescEvento { get; set; }
        public string DescEventoAbrev { get; set; }
        public string NroFormula { get; set; }
        public decimal? CodGrupEvento { get; set; }
        public decimal? ValorEvento { get; set; }
        public decimal? Expr1 { get; set; }
        public DateTime? FechaRevision { get; set; }
    }
}
