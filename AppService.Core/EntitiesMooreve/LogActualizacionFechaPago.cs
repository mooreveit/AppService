using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class LogActualizacionFechaPago
    {
        public decimal Id { get; set; }
        public string Cotizacion { get; set; }
        public DateTime? FechaPagoAnterior { get; set; }
        public DateTime? FechaPagoNueva { get; set; }
        public DateTime? FechaActualizado { get; set; }
    }
}
