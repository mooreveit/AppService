using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class CobEstadoDeCuenta
    {
        public decimal Id { get; set; }
        public double Rpdoc { get; set; }
        public string Rpdct { get; set; }
        public string Rpkco { get; set; }
        public string Rpsfx { get; set; }
        public double? Rpan8 { get; set; }
        public double? Rpag { get; set; }
        public double? Rpaap { get; set; }
        public string IdCliente { get; set; }
        public string Vendedor { get; set; }
        public string OficinaVenta { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? Iva { get; set; }
        public decimal? MontoOriginal { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string DocumentoSap { get; set; }
        public string Pltyp { get; set; }
    }
}
