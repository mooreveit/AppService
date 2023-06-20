using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CalculoMcAgrupadoProducto
    {
        public string NombreLinea { get; set; }
        public int? Parte { get; set; }
        public decimal? SumLista { get; set; }
        public decimal? SumVenta { get; set; }
        public decimal? Conc { get; set; }
        public decimal? SumMc { get; set; }
        public decimal? Mcventa { get; set; }
        public decimal? Mclista { get; set; }
        public decimal? Mc1 { get; set; }
    }
}
