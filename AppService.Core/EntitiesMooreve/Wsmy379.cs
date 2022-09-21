using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy379
    {
        public decimal Id { get; set; }
        public string CodLista { get; set; }
        public decimal? NivelAprob01 { get; set; }
        public decimal? NivelAprob02 { get; set; }
        public decimal? NivelMc { get; set; }
        public string FlagConcesion { get; set; }
        public string FlagExcepcion { get; set; }
        public string FlagExcepGeneral { get; set; }
        public string Observaciones { get; set; }
    }
}
