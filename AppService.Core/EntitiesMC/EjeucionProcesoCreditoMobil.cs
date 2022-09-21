using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class EjeucionProcesoCreditoMobil
    {
        public decimal Id { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public decimal? IdEvaluacion { get; set; }
        public string Usuario { get; set; }
    }
}
