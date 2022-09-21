using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaTasa
    {
        public decimal Id { get; set; }
        public decimal? Tasa { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
