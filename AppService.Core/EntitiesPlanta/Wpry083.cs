using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry083
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Cliente { get; set; }
        public DateTime? FechaProd { get; set; }
        public string TipoPapel { get; set; }
        public short Gramaje { get; set; }
        public string Color { get; set; }
        public string CodigoPapel { get; set; }
        public int Basica { get; set; }
        public int Opuesta { get; set; }
        public string TipoCaja { get; set; }
        public int Kilos { get; set; }
        public long FormasRodada { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public long FormasPedida { get; set; }
        public string EmpacarEn { get; set; }
        public string NumInd { get; set; }
        public string NumPresion { get; set; }
        public short AnchoRodado { get; set; }
    }
}
