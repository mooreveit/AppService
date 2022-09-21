using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy694
    {
        public decimal Recnum { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public string Ficha { get; set; }
        public decimal BsCuota { get; set; }
        public decimal BsVenta { get; set; }
        public decimal PorcCobertura { get; set; }
        public bool FlagMesActual { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? RbsCuota { get; set; }
        public decimal? RbsVenta { get; set; }
    }
}
