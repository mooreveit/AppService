using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class VProvision
    {
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
        public double? Monto { get; set; }
        public double? Saldo { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public int? Signo { get; set; }
        public string Rpglc { get; set; }
        public decimal? An8vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Vendedor { get; set; }
        public string Supervisor { get; set; }
        public short? Oficina { get; set; }
        public string NombOfic { get; set; }
        public string Condicion { get; set; }
        public string SolicitudVentas { get; set; }
        public string AprobacionCobranzas { get; set; }
        public string ObservacionesVentas { get; set; }
        public string ObservacionesCobranzas { get; set; }
        public decimal Id { get; set; }
        public string RechazoCobranzas { get; set; }
        public string UsuarioVentas { get; set; }
        public DateTime? FechaVentas { get; set; }
        public string UsuarioCredito { get; set; }
        public DateTime? FechaCredito { get; set; }
        public decimal? Rnc { get; set; }
        public string VendedorDeTransaccion { get; set; }
        public int? Dias { get; set; }
        public double? PorVencer { get; set; }
        public double? Vencido { get; set; }
        public double? PuntoCincoPorc { get; set; }
        public double? UnoPorc { get; set; }
        public double? CincoPorc { get; set; }
        public double? OchoPorc { get; set; }
        public double? QuincePorc { get; set; }
        public double? CienPorc { get; set; }
        public double? TotalProvision { get; set; }
        public string Periodo { get; set; }
        public string TipoNegocio { get; set; }
        public decimal? Refacturada { get; set; }
        public DateTime? NuevaFechaVencimiento { get; set; }
    }
}
