using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry060
    {
        public decimal Recnum { get; set; }
        public short CodigoMaquina { get; set; }
        public string RolloDoblado { get; set; }
        public short Anchos { get; set; }
        public long Orden { get; set; }
        public short LineaProd { get; set; }
        public long Cantidad { get; set; }
        public int MedidaBase { get; set; }
        public short PartesFormula { get; set; }
        public decimal Bolivares { get; set; }
        public decimal? Rbolivares { get; set; }
    }
}
