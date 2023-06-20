using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobIntegridadCobranzasVsWary074
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public long Documento { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public decimal? MontoCobrado { get; set; }
        public decimal? MontoRetenido { get; set; }
        public decimal? TotalCobroRetencion { get; set; }
        public decimal? TotalCobradoWary074 { get; set; }
        public decimal? Diferencia { get; set; }
        public decimal? TotalSapCobranzas { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
    }
}
