using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppPrice
    {
        public int Id { get; set; }
        public int? AppproductsId { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Precio { get; set; }

        public virtual AppProduct Appproducts { get; set; }
    }
}
