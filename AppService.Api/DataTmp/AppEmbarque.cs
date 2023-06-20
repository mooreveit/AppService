using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppEmbarque
    {
        public decimal Id { get; set; }
        public int? IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string NombreSubCategoria { get; set; }
        public decimal? TotalVenta { get; set; }
    }
}
