using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VResumenBatchFancnd
    {
        public DateTime? Fecha { get; set; }
        public decimal Batch { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Impuesto { get; set; }
        public string TipoDocumento { get; set; }
    }
}
