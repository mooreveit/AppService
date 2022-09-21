using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Winy256
    {
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
        public string Producto { get; set; }
        public DateTime? FechaCreado { get; set; }
        public string HoraCreado { get; set; }
        public string UsrCreo { get; set; }
        public bool? Anulado { get; set; }
        public DateTime? FechaAnulado { get; set; }
        public string HoraAnulado { get; set; }
        public string UsrAnulo { get; set; }
        public string Observaciones { get; set; }
    }
}
