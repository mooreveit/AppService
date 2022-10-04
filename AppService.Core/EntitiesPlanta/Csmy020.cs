using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Csmy020
    {
        public decimal Recnum { get; set; }
        public string Cotizacion { get; set; }
        public short Parte { get; set; }
        public short Numero { get; set; }
        public string CodProducto { get; set; }
        public string UnidadFactura { get; set; }
        public string DescProducto { get; set; }
        public long CantOrdenada { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal TotalLista { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal PrecioFactura { get; set; }
        public decimal PrecioCompetid { get; set; }
        public string TipoProducto { get; set; }
        public long Orden { get; set; }
        public short Correlativo { get; set; }
        public string ImpPorConsumo { get; set; }
        public DateTime FechaOrden { get; set; }
        public short LineaIncoming { get; set; }
        public string LineaProduccio { get; set; }
        public string FamiliaProduc { get; set; }
        public string MetodoLista { get; set; }
        public string DescForma { get; set; }
        public decimal ListaUniDolar { get; set; }
        public decimal VentaUniDolar { get; set; }
        public decimal ListaTotDolar { get; set; }
        public decimal VentaTotDolar { get; set; }
        public decimal TasaNegociacio { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal? RprecioLista { get; set; }
        public decimal? RprecioVenta { get; set; }
        public decimal? RtotalLista { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? RprecioFactura { get; set; }
        public decimal? RtasaNegociaci { get; set; }
    }
}
