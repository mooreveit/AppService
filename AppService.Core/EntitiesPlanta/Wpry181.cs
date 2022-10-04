using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry181
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public long JobId { get; set; }
        public int NroIq { get; set; }
        public DateTime? FecemiIq { get; set; }
        public DateTime? FecrecCont { get; set; }
        public DateTime? FecrecProd { get; set; }
        public DateTime? FecemiCart { get; set; }
        public DateTime? FecemiIr { get; set; }
        public DateTime? FecrecPlan { get; set; }
    }
}
