using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wivy194
    {
        public decimal Id { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public string Comprador { get; set; }
        public decimal? ReqRecMes { get; set; }
        public decimal? ReqAnulMes { get; set; }
        public decimal? ReqProcMes { get; set; }
        public decimal? ReqPenMes { get; set; }
        public decimal? ReqPenYt { get; set; }
        public decimal? ReqProYt { get; set; }
        public decimal? DifRePenProYt { get; set; }
        public decimal? PorcRendimiento { get; set; }
    }
}
