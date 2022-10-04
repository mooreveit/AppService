using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class TintasComune
    {
        public decimal Id { get; set; }
        public string Combinacion { get; set; }
        public decimal? CantTintas { get; set; }
        public string Comun { get; set; }
        public string Primera { get; set; }
        public string Segunda { get; set; }
        public string Tercera { get; set; }
    }
}
