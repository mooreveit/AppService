using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class HistoricoAprobacionCredito
    {
        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public decimal? Ceos { get; set; }
        public decimal? Stock { get; set; }
        public decimal? Imp { get; set; }
        public decimal? EdoCuentaTrans { get; set; }
        public decimal? PorFacturar { get; set; }
        public decimal? LimiteCreditoUt { get; set; }
        public decimal? UtBs { get; set; }
        public decimal? LimiteCreditoBs { get; set; }
        public decimal? SaldoLimiteCred { get; set; }
        public decimal? CodJdePadre { get; set; }
        public decimal? DiasCalle { get; set; }
        public string Cotizacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public decimal? Rimp { get; set; }
        public decimal? RutBs { get; set; }
        public decimal? RlimiteCreditoBs { get; set; }
        public decimal? RsaldoLimiteCred { get; set; }
    }
}
