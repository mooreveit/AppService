using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy353
    {
        public decimal Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FecValidDesde { get; set; }
        public DateTime? FecValidHasta { get; set; }
        public decimal? Porcentaje { get; set; }
        public string CodLista { get; set; }
        public string FlagRestriccion { get; set; }
        public decimal? VarBasico { get; set; }
    }
}
