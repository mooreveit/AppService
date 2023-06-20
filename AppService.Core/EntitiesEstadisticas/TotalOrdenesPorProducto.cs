using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class TotalOrdenesPorProducto
    {
        public decimal? MesContable { get; set; }
        public string TituloVentas { get; set; }
        public string NomProducto { get; set; }
        public string Producto { get; set; }
    }
}
