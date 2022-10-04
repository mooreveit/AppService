using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry072
    {
        public decimal Recnum { get; set; }
        public int NroProg { get; set; }
        public long Orden { get; set; }
        public short Parte { get; set; }
        public string CodigoPapel { get; set; }
        public decimal Ancho { get; set; }
        public decimal Kilos { get; set; }
        public long Cantidad { get; set; }
        public string CodigoCarbon { get; set; }
        public decimal AnchoCarbon { get; set; }
        public decimal KilosCarbon { get; set; }
    }
}
