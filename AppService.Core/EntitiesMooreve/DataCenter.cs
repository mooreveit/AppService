using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class DataCenter
    {
        public long IdRegistro { get; set; }
        public short Identificador { get; set; }
        public long Ficha { get; set; }
        public DateTime Fecha { get; set; }
    }
}
