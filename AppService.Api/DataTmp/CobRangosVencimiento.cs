using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobRangosVencimiento
    {
        public decimal Id { get; set; }
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? DiasDesde { get; set; }
        public decimal? DiasHasta { get; set; }
        public string Coletilla { get; set; }
        public string PieUno { get; set; }
        public string PieDos { get; set; }
    }
}
