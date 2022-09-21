using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VUltimoMes
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public decimal? AñoContable { get; set; }
        public decimal? MesContable { get; set; }
    }
}
