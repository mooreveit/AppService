using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy007
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public long? Cliente { get; set; }
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
        public string Observaciones { get; set; }
    }
}
