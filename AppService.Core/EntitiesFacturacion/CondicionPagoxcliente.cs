using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class CondicionPagoxcliente
    {
        public decimal? Cliente { get; set; }
        public decimal? CpMinima { get; set; }
        public decimal? CpPromedio { get; set; }
        public decimal? CpMaxima { get; set; }
    }
}
