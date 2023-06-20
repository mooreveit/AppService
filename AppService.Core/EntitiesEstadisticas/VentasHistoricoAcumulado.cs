using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasHistoricoAcumulado
    {
        public string Vendedor { get; set; }
        public decimal? TotalValorVenta { get; set; }
        public decimal? TotalValorLista { get; set; }
        public decimal? CantidadOrdenes { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Variacion { get; set; }
        public decimal? Concesion { get; set; }
    }
}
