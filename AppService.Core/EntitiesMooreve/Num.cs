using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Num
    {
        public string Rif { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Orden { get; set; }
        public string Cotizacion { get; set; }
        public string Copy { get; set; }
        public string Producto { get; set; }
        public string NumeroSerieControlDesde { get; set; }
        public string NumeroControlDesde { get; set; }
        public string NumeroSerieControlHasta { get; set; }
        public string NumeroControlHasta { get; set; }
        public string NumeroSerieFormatoDesde { get; set; }
        public string NumeroFormatoDesde { get; set; }
        public string NumeroSerieFormatoHasta { get; set; }
        public string NumeroFormatoHasta { get; set; }
        public string TipoDocumento { get; set; }
        public double? LongitudMascara { get; set; }
    }
}
