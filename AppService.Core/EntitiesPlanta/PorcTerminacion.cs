using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class PorcTerminacion
    {
        public decimal Id { get; set; }
        public decimal Categoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public string TipoPapel { get; set; }
        public decimal? PorcTerminacion1 { get; set; }
    }
}
