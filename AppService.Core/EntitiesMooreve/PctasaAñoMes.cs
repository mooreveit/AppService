using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PctasaAñoMes
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? Rtasa { get; set; }
    }
}
