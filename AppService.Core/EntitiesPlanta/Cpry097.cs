using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry097
    {
        public decimal Recnum { get; set; }
        public int NoPedido { get; set; }
        public string CodProducto { get; set; }
        public string UnidadFactura { get; set; }
        public string DescProducto { get; set; }
        public int CantOrdenada { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal TotalLista { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal PrecioFactura { get; set; }
        public string TipoProducto { get; set; }
        public long Orden { get; set; }
        public short Correlativo { get; set; }
        public decimal? RprecioLista { get; set; }
        public decimal? RprecioVenta { get; set; }
        public decimal? RtotalLista { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? RprecioFactura { get; set; }
    }
}
