using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class CobEstadoCuentaDto
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
        public string searchText { get; set; }
        public double? Saldo { get; set; }
        public string SaldoString { get; set; }
        public string BaseImponibleString { get; set; }
        public string IvaString { get; set; }
        public string MontoOriginalString { get; set; }

        public string Moneda { get; set; }




    }
}
