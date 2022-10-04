using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Stockporfacturarcliente
    {
        public int Cliente { get; set; }
        public decimal? PorFacturar { get; set; }
    }
}
