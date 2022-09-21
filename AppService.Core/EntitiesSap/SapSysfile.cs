using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapSysfile
    {
        public decimal Id { get; set; }
        public DateTime? UltimaEjecucionCobranzas { get; set; }
        public string MonedaLocal { get; set; }
        public string MonedaExtranjera { get; set; }
    }
}
