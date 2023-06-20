using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class IngresosPorVendedor
    {
        public string TipoNomina { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Mes { get; set; }
        public string Ficha { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? CodigoConcepto { get; set; }
        public string ConceptoPago { get; set; }
        public decimal? MontoPago { get; set; }
        public string CodigoVendedor { get; set; }
    }
}
