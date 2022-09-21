using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy451
    {
        public int Recnum { get; set; }
        public int? RecVendedor { get; set; }
        public int? RecSubCategoria { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Año { get; set; }
        public decimal? CuotaProducto { get; set; }
        public decimal? CuotaAcumulada { get; set; }
        public int? RecOficina { get; set; }
        public string Teamleader { get; set; }
        public decimal? RcuotaProducto { get; set; }
        public decimal? RcuotaAcumulada { get; set; }
        public string CodVendedor { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
    }
}
