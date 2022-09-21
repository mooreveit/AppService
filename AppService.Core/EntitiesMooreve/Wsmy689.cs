using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy689
    {
        public decimal Recnum { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public short IdOficina { get; set; }
        public int IdCuota { get; set; }
        public decimal BsCuota { get; set; }
        public decimal BsVenta { get; set; }
        public decimal PorcCobertura { get; set; }
        public decimal PorcMixPro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCuotaPadre { get; set; }
    }
}
