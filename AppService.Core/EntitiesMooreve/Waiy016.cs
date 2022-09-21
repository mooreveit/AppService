using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy016
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? Job { get; set; }
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
        public string Producto { get; set; }
        public decimal? CantidadCajas { get; set; }
        public decimal? CantidadMillares { get; set; }
        public decimal? CodDpto { get; set; }
    }
}
