using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class VDetallePronostico
    {
        public string NombOfic { get; set; }
        public string NombreVendedor { get; set; }
        public string Cia { get; set; }
        public string Auxiliar { get; set; }
        public string Transaccion { get; set; }
        public string DescTransaccion { get; set; }
        public string Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? CondPago { get; set; }
        public double? An8 { get; set; }
        public string NombreAn8 { get; set; }
        public double? CodLegacy { get; set; }
        public double? Expr1 { get; set; }
        public double? Saldo { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public double? SaldoOrg { get; set; }
        public string Rpglc { get; set; }
        public string AprobacionCobranzas { get; set; }
        public double? Pronosticado { get; set; }
        public double? Ajustar { get; set; }
        public string SolicitudVentas { get; set; }
        public string ObservacionesVentas { get; set; }
        public string ObservacionesCobranzas { get; set; }
        public string Vendedor { get; set; }
        public string Supervisor { get; set; }
    }
}
