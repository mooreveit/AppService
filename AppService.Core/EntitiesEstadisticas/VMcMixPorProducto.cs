using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VMcMixPorProducto
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string Descripcion { get; set; }
        public string PrintNoPrint { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Bsmc { get; set; }
    }
}
