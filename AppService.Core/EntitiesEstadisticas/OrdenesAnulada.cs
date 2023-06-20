using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class OrdenesAnulada
    {
        public decimal? Orden { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
    }
}
