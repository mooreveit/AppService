using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCotizacionesGanadasAñoMesVendedor
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Vendedor { get; set; }
        public decimal TotalPropuesta { get; set; }
    }
}
