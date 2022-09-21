using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Waiy011
    {
        public decimal Id { get; set; }
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? CodDpto { get; set; }
        public string Observaciones { get; set; }
    }
}
