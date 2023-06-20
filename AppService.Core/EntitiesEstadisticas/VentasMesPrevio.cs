using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasMesPrevio
    {
        public string Vendedor { get; set; }
        public string TituloVentas { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
    }
}
