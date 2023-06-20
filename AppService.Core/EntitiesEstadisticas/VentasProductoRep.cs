using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VentasProductoRep
    {
        public string Vendedor { get; set; }
        public string TituloVentas { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? Concesion { get; set; }
        public decimal? Orden { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Variacion { get; set; }
        public string DescMes { get; set; }
        public string CodigoGrupo { get; set; }
    }
}
