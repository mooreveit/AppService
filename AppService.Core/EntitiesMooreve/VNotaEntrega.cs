using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VNotaEntrega
    {
        public short? Almacen { get; set; }
        public short? CodTransaccion { get; set; }
        public int? Documento { get; set; }
        public string Producto { get; set; }
        public decimal? Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public long? Cliente { get; set; }
        public int? CondPago { get; set; }
        public int? TipoIva { get; set; }
        public decimal? Orden { get; set; }
        public string Cotizacion { get; set; }
        public decimal? OrdenCompra { get; set; }
        public string Observaciones { get; set; }
        public short? AlmacenReceptor { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public string Usuario { get; set; }
        public string FormaImp { get; set; }
        public short UnidadCosteo { get; set; }
        public int CantidadXCaja { get; set; }
        public string NomOficina { get; set; }
        public string DescripcionTipoIva { get; set; }
        public string DEscripcionCondPago { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
