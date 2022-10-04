using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Ceosporfacturarclientedetalle
    {
        public decimal NumCot { get; set; }
        public string Codigo { get; set; }
        public decimal? VentaTot { get; set; }
        public decimal Orden { get; set; }
        public string CodigoClient { get; set; }
        public string Estado { get; set; }
        public string AfectaBacklog { get; set; }
    }
}
