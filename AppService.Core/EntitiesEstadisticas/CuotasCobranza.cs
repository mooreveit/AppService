using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CuotasCobranza
    {
        public string CodVendedor { get; set; }
        public decimal Cuota { get; set; }
        public decimal Mes { get; set; }
        public decimal Ano { get; set; }
    }
}
