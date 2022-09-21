using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Pccliente
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public DateTime? FApertura { get; set; }
        public DateTime? FUltmCompra { get; set; }
        public DateTime? FechaReactivado { get; set; }
    }
}
