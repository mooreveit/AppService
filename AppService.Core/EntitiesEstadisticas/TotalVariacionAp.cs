using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class TotalVariacionAp
    {
        public string Vendedor { get; set; }
        public decimal? TotalValorVenta { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
    }
}
