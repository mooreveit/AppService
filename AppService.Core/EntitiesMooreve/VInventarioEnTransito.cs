using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VInventarioEnTransito
    {
        public short? AlmacenReceptor { get; set; }
        public short Bodega { get; set; }
        public short CodTransaccion { get; set; }
        public int Comprobante { get; set; }
        public string Producto { get; set; }
        public int? Cantidad { get; set; }
        public int? CantidadRecibida { get; set; }
        public int? Diferencia { get; set; }
        public string Actualizado { get; set; }
        public long? OrdProduccion { get; set; }
        public long? OrdenCompra { get; set; }
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
        public short? AlmacenEmisor { get; set; }
    }
}
