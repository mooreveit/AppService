using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Backlog
    {
        public string NumeroPedido { get; set; }
        public string Orden { get; set; }
        public DateTime? FechaPedido { get; set; }
        public decimal? CantPedida { get; set; }
        public decimal? Cantidadxcaja { get; set; }
        public decimal? CantFacturada { get; set; }
        public string Usuario { get; set; }
        public string CodProducto { get; set; }
        public decimal? DiasDeAtrazo { get; set; }
        public string DescripcionProducto { get; set; }
        public string CodVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public DateTime? FechaProg { get; set; }
        public decimal? CantProg { get; set; }
        public string DescStatus { get; set; }
        public string DescEstacion { get; set; }
        public string NombreCliente { get; set; }
        public decimal? TotalVenta { get; set; }
        public string TipoProducto { get; set; }
        public string DescLinea { get; set; }
        public decimal? CodResponsable { get; set; }
        public decimal? RtotalVenta { get; set; }
    }
}
