using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrFechaFeriadum
    {
        public decimal Recnum { get; set; }
        public DateTime FechaFeriada { get; set; }
        public string Motivo { get; set; }
        public string MostrarBs { get; set; }
    }
}
