using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy400
    {
        public int IdAutorizacion { get; set; }
        public int Oficina { get; set; }
        public string Autoriza { get; set; }
        public string Autorizado { get; set; }
        public decimal? Conc { get; set; }
        public decimal? Mc { get; set; }
        public string NivelAprob { get; set; }
    }
}
