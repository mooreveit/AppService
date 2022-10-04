using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry180
    {
        public decimal Recnum { get; set; }
        public string Orden { get; set; }
        public string Maq { get; set; }
        public string CodPapel { get; set; }
        public string Ancho { get; set; }
        public string Kilos { get; set; }
        public string Partes { get; set; }
        public DateTime? FechaOrden { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Cliente { get; set; }
        public string FlagCarbon { get; set; }
    }
}
