using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry006
    {
        public decimal Recnum { get; set; }
        public short CentroCost { get; set; }
        public string Descripcion { get; set; }
        public short TiempoProceso { get; set; }
        public short ProcesoTermina { get; set; }
    }
}
