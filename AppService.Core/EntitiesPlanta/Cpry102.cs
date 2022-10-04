using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry102
    {
        public decimal Recnum { get; set; }
        public int JobContrato { get; set; }
        public int JobIdProceso { get; set; }
        public long OrdenProceso { get; set; }
        public string CodProducto { get; set; }
        public long Cantidad { get; set; }
    }
}
