using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VNuevoPlanCompensacion
    {
        public string Transaccion { get; set; }
        public decimal Documento { get; set; }
        public string TranCancela { get; set; }
        public decimal DocCancela { get; set; }
        public short DiasCalle { get; set; }
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public decimal Monto { get; set; }
        public long Orden { get; set; }
        public string Producto { get; set; }
        public decimal MontoReal { get; set; }
        public decimal PorcComision { get; set; }
        public decimal BsComision { get; set; }
        public decimal? BsComicionActual { get; set; }
        public decimal PorcDeduccion { get; set; }
        public decimal BsDeduccion { get; set; }
        public DateTime PeriodoDesde { get; set; }
        public DateTime PeriodoHasta { get; set; }
        public decimal PorcMixProduct { get; set; }
        public int IdExcepcion { get; set; }
        public decimal PorcComisionRegulada { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
