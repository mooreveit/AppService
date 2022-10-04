using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry093
    {
        public decimal Recnum { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public short NumeroPartes { get; set; }
        public decimal PrecioIntercom { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public decimal? RprecioInterco { get; set; }
    }
}
