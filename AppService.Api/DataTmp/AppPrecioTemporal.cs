using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppPrecioTemporal
    {
        public decimal Id { get; set; }
        public decimal? IdPrecio { get; set; }
        public decimal? PrecioNuevo { get; set; }
    }
}
