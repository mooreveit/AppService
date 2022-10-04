using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Clientesenproceso
    {
        public string Codigo { get; set; }
        public double? CodJde { get; set; }
        public string Nombre { get; set; }
        public string Inactivo { get; set; }
        public decimal Ceos { get; set; }
        public decimal Stock { get; set; }
        public decimal Imp { get; set; }
        public decimal EdoCuentaTrans { get; set; }
        public decimal? PorFacturar { get; set; }
        public decimal? LimiteCreditoUt { get; set; }
        public decimal UtBs { get; set; }
        public decimal? LimiteCreditoBs { get; set; }
        public decimal? SaldoLimiteCred { get; set; }
        public double? CodJdePadre { get; set; }
        public decimal? DiasCalle { get; set; }
        public decimal FacturacionPendienteContabilizar { get; set; }
        public decimal? LimiteVsSaldo { get; set; }
    }
}
