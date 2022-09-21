using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class EjeucionProcesoCredito
    {
        public decimal Id { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string Cotizacion { get; set; }
        public string Usuario { get; set; }
    }
}
