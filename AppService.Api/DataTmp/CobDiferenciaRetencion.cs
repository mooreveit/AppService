using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobDiferenciaRetencion
    {
        public int? AñoCobro { get; set; }
        public int? MesCobro { get; set; }
        public string Region { get; set; }
        public string Oficina { get; set; }
        public string Vendedor { get; set; }
        public string NombreCliente { get; set; }
        public long? Documento { get; set; }
        public string DocumentoSap { get; set; }
        public string NroComprobante { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? BsEmision { get; set; }
        public DateTime? FechaContabilizacion { get; set; }
        public decimal? TasaContabilizacion { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public decimal? TasaComprobante { get; set; }
        public decimal? DolaresContabilizacion { get; set; }
        public decimal? DolaresComprobante { get; set; }
        public decimal? DolaresFechaFactura { get; set; }
        public decimal? Diferencia { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? AñoFactura { get; set; }
        public int? MesFactura { get; set; }
        public int? DiaFactura { get; set; }
        public int? AñoContabilizacion { get; set; }
        public int? MesContabilizacion { get; set; }
        public int? DiaContabilizacion { get; set; }
        public int? CorteFactura { get; set; }
        public int? CorteCobro { get; set; }
        public int? FactorDiferencia { get; set; }
    }
}
