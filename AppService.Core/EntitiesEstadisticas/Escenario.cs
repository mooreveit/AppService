using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Escenario
    {
        public string NombreVend { get; set; }
        public string Linea1 { get; set; }
        public int? Parte { get; set; }
        public decimal? Lista { get; set; }
        public decimal? Venta { get; set; }
        public decimal? BsmcVenta { get; set; }
        public decimal? BsmcLista { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Fm { get; set; }
    }
}
