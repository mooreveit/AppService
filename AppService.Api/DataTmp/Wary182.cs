using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class Wary182
    {
        public decimal Recnum { get; set; }
        public int Nota { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVenc { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cliente { get; set; }
        public long Orden { get; set; }
        public string Contrapartida { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Ivaporc { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string DatosCliente { get; set; }
        public string Observacion1 { get; set; }
        public string Banco { get; set; }
        public string Region { get; set; }
        public string Cobrador { get; set; }
        public decimal Cantidad { get; set; }
        public string FlagImpreso { get; set; }
        public string NombreFact { get; set; }
        public string DireccionFact1 { get; set; }
        public string DireccionFact2 { get; set; }
        public string DireccionFact3 { get; set; }
        public string RifFact { get; set; }
        public string NitFact { get; set; }
        public string Observacion2 { get; set; }
        public string Observacion3 { get; set; }
        public string Observacion4 { get; set; }
        public string Anulada { get; set; }
        public decimal Subtotald { get; set; }
        public decimal Ivad { get; set; }
        public decimal Totald { get; set; }
        public decimal Cambio { get; set; }
        public long NroControl { get; set; }
        public string Transaccion { get; set; }
        public decimal? Batch { get; set; }
        public decimal? Rsubtotal { get; set; }
        public decimal? Riva { get; set; }
        public decimal? Rtotal { get; set; }
        public decimal? CodJdepadre { get; set; }
    }
}
