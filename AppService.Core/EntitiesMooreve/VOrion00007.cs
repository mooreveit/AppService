using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VOrion00007
    {
        public string CodEvento { get; set; }
        public string CodSubEvento { get; set; }
        public string DescEvento { get; set; }
        public string DescEventoAbrev { get; set; }
        public DateTime? FecValidIni { get; set; }
        public DateTime? FecValidFin { get; set; }
        public decimal? CodGrupEvento { get; set; }
    }
}
