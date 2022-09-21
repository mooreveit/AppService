using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy640
    {
        public long Recnum { get; set; }
        public long Id { get; set; }
        public short IdParte { get; set; }
        public string IdPapel { get; set; }
        public int MedidaBasica { get; set; }
        public int MedidaOpuesta { get; set; }
        public string Carbon { get; set; }
        public decimal MedOpuesCarbon { get; set; }
        public string CarbonSpot { get; set; }
        public int? TalonExtra { get; set; }
    }
}
