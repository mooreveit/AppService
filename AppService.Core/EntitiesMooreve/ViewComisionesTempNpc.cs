using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class ViewComisionesTempNpc
    {
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Transaccion { get; set; }
        public decimal Documento { get; set; }
        public short Linea { get; set; }
        public string TranCancela { get; set; }
        public decimal DocCancela { get; set; }
        public short LineaCancela { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public decimal Monto { get; set; }
        public decimal PorFactura { get; set; }
        public decimal Impuesto { get; set; }
        public long Orden { get; set; }
        public string Producto { get; set; }
        public int IdSubCategoria { get; set; }
        public string NombreSubCategoria { get; set; }
        public decimal MontoReal { get; set; }
        public DateTime PeriodoDesde { get; set; }
        public DateTime PeriodoHasta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal IdSolicitud { get; set; }
        public decimal BsComision { get; set; }
        public bool FlagParcial { get; set; }
        public decimal RecNumPadre { get; set; }
    }
}
