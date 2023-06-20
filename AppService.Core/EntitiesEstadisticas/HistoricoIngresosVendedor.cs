using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class HistoricoIngresosVendedor
    {
        public decimal? Ano { get; set; }
        public decimal? Mes { get; set; }
        public string CodigoVendedor { get; set; }
        public decimal? Ingreso { get; set; }
    }
}
