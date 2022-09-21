using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class StatusDetalle
    {
        public decimal Id { get; set; }
        public long? Orden { get; set; }
        public string Producto { get; set; }
        public decimal? IdEstacionDesde { get; set; }
        public decimal? IdEstacionHasta { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int? Cantidad { get; set; }
        public int? Documento { get; set; }
    }
}
