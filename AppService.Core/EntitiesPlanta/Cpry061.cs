using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry061
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public long Cantidad { get; set; }
        public string McpoRuptura { get; set; }
        public string EdoRuptura { get; set; }
        public string Mcpo { get; set; }
        public string Edo { get; set; }
        public string Estacion { get; set; }
        public short Depto { get; set; }
        public decimal ValorVenta { get; set; }
        public short Oficina { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
