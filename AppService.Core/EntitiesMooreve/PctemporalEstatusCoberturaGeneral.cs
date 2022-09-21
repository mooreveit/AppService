using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PctemporalEstatusCoberturaGeneral
    {
        public int Id { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? Comision { get; set; }
        public string EstasAqui { get; set; }
    }
}
