using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny055
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public short NroCaja { get; set; }
        public string PrefDesde { get; set; }
        public string NumeroDesde { get; set; }
        public string SufDesde { get; set; }
        public string PrefHasta { get; set; }
        public string NumeroHasta { get; set; }
        public string SufHasta { get; set; }
        public string PrefijoCli { get; set; }
        public string SufijoCli { get; set; }
        public string NumCliDesde { get; set; }
        public string NumCliHasta { get; set; }
    }
}
