using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasHistoricoAcumGrupoAp
    {
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? CantOrdenes { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
        public string CodigoGrupo { get; set; }
    }
}
