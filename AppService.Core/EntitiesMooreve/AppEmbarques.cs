using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppEmbarques
    {
        public decimal Id { get; set; }
        public int? IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string NombreSubCategoria { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? RtotalVenta { get; set; }
    }
}
