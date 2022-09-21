using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy365
    {
        public decimal IdEvento { get; set; }
        public string EventoMatriz { get; set; }
        public string CodEvento { get; set; }
        public string CodLista { get; set; }
        public string Formato { get; set; }
        public string Formato1 { get; set; }
        public decimal? CantIni { get; set; }
        public decimal? CantFin { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Cargo { get; set; }
        public decimal? RestParte { get; set; }
        public string RestTinta { get; set; }
        public string RestPapel { get; set; }
        public string RestVarBasico { get; set; }
    }
}
