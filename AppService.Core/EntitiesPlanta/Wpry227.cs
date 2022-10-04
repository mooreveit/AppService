using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry227
    {
        public DateTime? FechaOrden { get; set; }
        public string JobId { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FechaSalProd { get; set; }
        public DateTime? FechaSalFact { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaDespacho { get; set; }
        public decimal? Factura { get; set; }
        public decimal? CantFactura { get; set; }
        public decimal? CantOrdenada { get; set; }
        public string Historicobacklog { get; set; }
        public string Printnoprint { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public string Cliente { get; set; }
        public decimal? RprecioLista { get; set; }
        public decimal? RprecioVenta { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
    }
}
