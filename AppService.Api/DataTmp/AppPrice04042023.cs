using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppPrice04042023
    {
        public int Id { get; set; }
        public int? AppproductsId { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Precio { get; set; }
    }
}
