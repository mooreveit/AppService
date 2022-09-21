using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Ciny042
    {
        public decimal Recnum { get; set; }
        public string Cia { get; set; }
        public short Mescon { get; set; }
        public DateTime FechaComprb { get; set; }
        public string TipoComprb { get; set; }
        public int NumeroComprb { get; set; }
        public string CuentaContab { get; set; }
        public string Concepto { get; set; }
        public decimal Debito { get; set; }
        public decimal Credito { get; set; }
        public int Linea { get; set; }
    }
}
