using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry039
    {
        public decimal Recnum { get; set; }
        public string TipoOrden { get; set; }
        public long Cantidad { get; set; }
        public short Dias { get; set; }
        public short DiasHabiles { get; set; }
    }
}
