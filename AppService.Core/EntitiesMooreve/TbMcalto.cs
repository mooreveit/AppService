using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class TbMcalto
    {
        public decimal Id { get; set; }
        public decimal? Orden { get; set; }
        public decimal? PorcMc { get; set; }
        public DateTime? Procesado { get; set; }
        public decimal? MargenAprobado { get; set; }
    }
}
