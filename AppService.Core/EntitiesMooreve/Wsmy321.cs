using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy321
    {
        public int Id { get; set; }
        public string CodEvento { get; set; }
        public string CodSubEvento { get; set; }
        public string DescEvento { get; set; }
        public string AplicFijVar { get; set; }
        public string DescFiVa { get; set; }
        public decimal? CodGrupEvento { get; set; }
        public string CodGrupSubEvento { get; set; }
        public string TpEvento { get; set; }
        public string TpEventoUtil { get; set; }
        public string DescEventoAbrev { get; set; }
        public DateTime? FecValidIni { get; set; }
        public DateTime? FecValidFin { get; set; }
    }
}
