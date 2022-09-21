using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EvalCreditoFact
    {
        public decimal Id { get; set; }
        public decimal IdEvaluacion { get; set; }
        public string CodCliente { get; set; }
        public decimal? Monto { get; set; }
        public decimal? IdSolicitudAnalisis { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Aprobado { get; set; }
        public decimal? Rmonto { get; set; }
    }
}
