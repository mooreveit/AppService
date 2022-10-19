using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumoPorProveedor
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? Proveedor { get; set; }
        public string Codigo { get; set; }
        public decimal? Kilos { get; set; }
        public string Nombre { get; set; }
    }
}
