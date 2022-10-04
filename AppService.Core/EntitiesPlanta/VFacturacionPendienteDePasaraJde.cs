using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VFacturacionPendienteDePasaraJde
    {
        public int Cliente { get; set; }
        public decimal? PorFacturar { get; set; }
        public string TotalParcial { get; set; }
    }
}
