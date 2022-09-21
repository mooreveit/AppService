using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwConsolidadoAnalisisDeVencimiento
    {
        public string Cia { get; set; }
        public string Auxiliar { get; set; }
        public string Transaccion { get; set; }
        public string DescTransaccion { get; set; }
        public string Documento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public long? CondPago { get; set; }
        public double? An8 { get; set; }
        public string NombreAn8 { get; set; }
        public double? CodLegacy { get; set; }
        public double? Monto { get; set; }
        public double? Saldo { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public int? Signo { get; set; }
        public string Rpglc { get; set; }
        public string An8vendedor { get; set; }
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
        public decimal? Comision { get; set; }
        public string TipoNegocio { get; set; }
        public string Top20Cia { get; set; }
        public string Top20Oficina { get; set; }
        public decimal? Dias { get; set; }
        public decimal? Sinvencer { get; set; }
        public decimal? Rango1 { get; set; }
        public decimal? Rango2 { get; set; }
        public decimal? Rango3 { get; set; }
        public decimal? Rango4 { get; set; }
        public decimal? Provision { get; set; }
        public decimal? PorcProvision { get; set; }
        public DateTime? NuevaFechaVencimiento { get; set; }
        public decimal? Refacturada { get; set; }
        public double? IdAn8 { get; set; }
        public double? Rmonto { get; set; }
        public double? Rsaldo { get; set; }
        public decimal? Rrango1 { get; set; }
        public decimal? Rrango2 { get; set; }
        public decimal? Rrango3 { get; set; }
        public decimal? Rrango4 { get; set; }
    }
}
