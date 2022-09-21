using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wimy030
    {
        public string Usuario { get; set; }
        public string Almacen { get; set; }
        public string Codigo { get; set; }
        public string Medida { get; set; }
        public string Ubicacion { get; set; }
        public DateTime? FechaTransac { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
    }
}
