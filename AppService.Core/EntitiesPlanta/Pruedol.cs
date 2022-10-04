using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Pruedol
    {
        public decimal Recnum { get; set; }
        public short Lista { get; set; }
        public string Parametro1 { get; set; }
        public long ValorIni1 { get; set; }
        public long ValorFin1 { get; set; }
        public string Parametro2 { get; set; }
        public long ValorIni2 { get; set; }
        public long ValorFin2 { get; set; }
    }
}
