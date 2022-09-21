using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy700
    {
        public decimal Recnum { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public int Factura { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaGeneracion { get; set; }
    }
}
