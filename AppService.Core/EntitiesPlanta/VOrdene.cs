using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VOrdene
    {
        public DateTime FechaOrden { get; set; }
        public long JobId { get; set; }
        public long Orden { get; set; }
        public DateTime? FechaerEmbarqu { get; set; }
        public DateTime? FechasrEmbarqu { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public long? CantFactura { get; set; }
        public long CantOrdenada { get; set; }
        public int? NumeroFactura { get; set; }
        public string UsuarioCancelo { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal TotalLista { get; set; }
        public decimal TotalVenta { get; set; }
        public string Historicobacklog { get; set; }
    }
}
