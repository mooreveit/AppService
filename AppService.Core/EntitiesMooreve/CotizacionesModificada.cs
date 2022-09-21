using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CotizacionesModificada
    {
        public decimal Id { get; set; }
        public string Cotizacion { get; set; }
        public bool? Procesado { get; set; }
        public DateTime? FechaModificada { get; set; }
    }
}
