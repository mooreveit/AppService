using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class OrdenesReportadasSeniat
    {
        public long Orden { get; set; }
        public long Factura { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
    }
}
