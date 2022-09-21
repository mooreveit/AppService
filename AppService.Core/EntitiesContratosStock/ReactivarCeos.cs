using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class ReactivarCeos
    {
        public decimal? Orden { get; set; }
        public decimal? NumCot { get; set; }
        public string Usuario { get; set; }
        public string MotivoReactivacion { get; set; }
        public decimal? DiaReactivacion { get; set; }
        public decimal? MesReactivacion { get; set; }
        public decimal? AnoReactivacion { get; set; }
    }
}
