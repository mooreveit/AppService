using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry100
    {
        public decimal Recnum { get; set; }
        public int NoPedido { get; set; }
        public string Instru01 { get; set; }
        public string Instru02 { get; set; }
        public string Instru03 { get; set; }
        public short Correlativo { get; set; }
        public long Orden { get; set; }
    }
}
