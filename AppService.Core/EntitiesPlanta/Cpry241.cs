using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry241
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public int Factura { get; set; }
        public int Remision { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaProgramad { get; set; }
        public short DiasAtraso { get; set; }
        public string Cliente { get; set; }
        public short Oficina { get; set; }
    }
}
