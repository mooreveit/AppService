using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryNominaVentas01
    {
        public string Codigo { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? ComisionVentas { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
        public string ConceptoPago { get; set; }
    }
}
