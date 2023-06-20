using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VVentasProductoMayor
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string ProductoMayor { get; set; }
        public decimal? Vv { get; set; }
        public decimal? Vl { get; set; }
        public decimal? Ordenes { get; set; }
        public decimal? VlDolares { get; set; }
        public decimal? VvDolares { get; set; }
        public decimal? BsMc { get; set; }
        public string Vendedor { get; set; }
        public string Supervisor { get; set; }
        public string NombreVendedor { get; set; }
        public string Oficina { get; set; }
    }
}
