using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy030bk
    {
        public decimal Recnum { get; set; }
        public int NroIr { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVcto { get; set; }
        public string Factura { get; set; }
        public string NotaEntrega { get; set; }
        public int Proveedor { get; set; }
        public decimal TotalDebito { get; set; }
        public decimal TotalCredito { get; set; }
        public string Pasar { get; set; }
        public short UltimoItem { get; set; }
        public decimal PorcIva { get; set; }
        public short CondicionPago { get; set; }
        public string Observacion { get; set; }
        public string Prefijo { get; set; }
        public string Sufijo { get; set; }
        public long FaControl { get; set; }
        public decimal PorcRetIva { get; set; }
        public long TipoPago { get; set; }
        public string Nombre { get; set; }
    }
}
