using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryCuotasxventa
    {
        public string Vendedor { get; set; }
        public decimal? Venta { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Cuota { get; set; }
        public decimal? Cobertura { get; set; }
    }
}
