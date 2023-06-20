using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatProductoMayorParte
    {
        public long CatProductoMayorPartesId { get; set; }
        public long? CatProductoMayorId { get; set; }
        public string CodigoProduct { get; set; }
        public int Partes { get; set; }
        public int Frecuencia { get; set; }
    }
}
