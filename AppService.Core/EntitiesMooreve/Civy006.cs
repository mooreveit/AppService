using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Civy006
    {
        public decimal Recnum { get; set; }
        public short Bodega { get; set; }
        public string Producto { get; set; }
        public string OrigenProducto { get; set; }
        public string LineaProducto { get; set; }
        public string FamiliaProduct { get; set; }
        public string TipoProducto { get; set; }
        public short CodTransaccion { get; set; }
        public DateTime FechaComprb { get; set; }
        public int Comprobante { get; set; }
        public long? OrdenCompra { get; set; }
        public long? OrdProduccion { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorCosto { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public short CentroGastos { get; set; }
        public long? Cliente { get; set; }
        public string OrdenCalculo { get; set; }
        public string Transmision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Item { get; set; }
        public long? NoPedido { get; set; }
        public long? NoOrden { get; set; }
        public short? MesConfirma { get; set; }
        public short? AnoConfirma { get; set; }
        public short? Ano { get; set; }
        public string NoAfectaProm { get; set; }
        public short? AlmacenReceptor { get; set; }
        public short? AlmacenEmisor { get; set; }
        public int? CantidadRecibida { get; set; }
        public string Actualizado { get; set; }
        public string Observaciones { get; set; }
        public decimal? NumLote { get; set; }
        public string PreDespacho { get; set; }
        public decimal? Factura { get; set; }
        public int? ComprobanteOri { get; set; }
        public string Ajustado { get; set; }
        public string NombreTransaccion { get; set; }
        public string NombreAlmacen { get; set; }
        public string NombreProducto { get; set; }
        public long? NumeroOrdenfa { get; set; }
        public int? Factura56 { get; set; }
        public int? Remision { get; set; }
        public long? NumeroOrdenre { get; set; }
        public string NombreCliente { get; set; }
        public string Medida { get; set; }
        public int? CantidadXCaja { get; set; }
        public int? Facturare { get; set; }
    }
}
