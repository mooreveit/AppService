using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Cary016
    {
        public decimal Recnum { get; set; }
        public short CodTrans { get; set; }
        public int Factura { get; set; }
        public short Letra { get; set; }
        public short TotLetra { get; set; }
        public int Cliente { get; set; }
        public int Comprobante { get; set; }
        public DateTime FechaFactura { get; set; }
        public long Orden { get; set; }
        public DateTime? FechaVenci { get; set; }
        public decimal MontoOriginal { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Impuesto { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal OtrosCreditos { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoOrig { get; set; }
        public decimal MontoPag { get; set; }
        public decimal OtrosCargos1 { get; set; }
        public decimal OtrosCreditos1 { get; set; }
        public decimal Saldo1 { get; set; }
        public DateTime FechaConfirma { get; set; }
        public DateTime? FechaCobro { get; set; }
        public DateTime? FechaVisita { get; set; }
        public string TipoDocRecib { get; set; }
        public short Centro { get; set; }
        public short Correlativo { get; set; }
        public long Recibo { get; set; }
        public short Pais { get; set; }
        public string TipoProducto { get; set; }
        public string Vendedor { get; set; }
        public string Supervisor { get; set; }
        public decimal PorcConcesion { get; set; }
        public string ComisPag { get; set; }
        public short Linea { get; set; }
    }
}
