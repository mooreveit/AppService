using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class LogSysfile
    {
        public decimal? UltimoControl { get; set; }
        public decimal? NuevoControl { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
