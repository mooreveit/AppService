using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CreActualizaClienteCotizacion
    {
        public decimal Id { get; set; }
        public string Cotizacion { get; set; }
        public string Cliente { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
    }
}
