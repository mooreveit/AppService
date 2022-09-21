using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VBacklogPlanta
    {
        public short Bodega { get; set; }
        public string Codigo { get; set; }
        public int ExistActual { get; set; }
        public int? CantProg { get; set; }
    }
}
