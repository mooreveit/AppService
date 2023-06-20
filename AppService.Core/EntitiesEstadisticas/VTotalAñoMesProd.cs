using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VTotalAñoMesProd
    {
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public decimal? Orden { get; set; }
        public string Producto { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Formas { get; set; }
    }
}
