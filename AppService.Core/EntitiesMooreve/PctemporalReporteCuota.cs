using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PctemporalReporteCuota
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Cuota { get; set; }
        public string Venta { get; set; }
        public string Cumplimiento { get; set; }
    }
}
