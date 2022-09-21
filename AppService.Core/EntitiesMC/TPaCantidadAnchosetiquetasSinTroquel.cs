using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaCantidadAnchosetiquetasSinTroquel
    {
        public decimal Id { get; set; }
        public decimal? MedidaOpuestaDecimalDesde { get; set; }
        public decimal? MedidaOpuestaDecimalHasta { get; set; }
        public decimal? CantAnchos { get; set; }
    }
}
