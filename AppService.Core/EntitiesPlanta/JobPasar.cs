using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class JobPasar
    {
        public long? Job { get; set; }
        public long? Cantidad { get; set; }
        public string Producto { get; set; }
        public long? Orden { get; set; }
    }
}
