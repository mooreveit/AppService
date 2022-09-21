using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class BacklogNoFacturar
    {
        public long Orden { get; set; }
        public string CodProducto { get; set; }
        public decimal? PorcMcFinan { get; set; }
    }
}
