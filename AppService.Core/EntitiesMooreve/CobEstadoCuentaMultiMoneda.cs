using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CobEstadoCuentaMultiMoneda
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public string ClaseDoc { get; set; }
        public string DescripcionClaseDocumento { get; set; }
        public string DocumentoSap { get; set; }
        public string DocumentoExterno { get; set; }
        public DateTime? FechaDoc { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal? Monto { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? Saldo { get; set; }
        public string Moneda { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string NombreCliente { get; set; }
        public string OficinaVenta { get; set; }
        public string NombreOficina { get; set; }
        public decimal? TasaBancoCentral { get; set; }
        public decimal? TasaReferencial { get; set; }
        public string Cotizacion { get; set; }
        public long? Orden { get; set; }
        public decimal? MontoUsd { get; set; }
        public decimal? BaseImponibleUsd { get; set; }
        public decimal? ImpuestoUsd { get; set; }
        public decimal? SaldoUsd { get; set; }
        public decimal? RetencionPendienteUsd { get; set; }

        public decimal? FechaActualBancoCentralMontoUsd { get; set; }
        public decimal? FechaActualBancoCentralBaseImponibleUsd { get; set; }
        public decimal? FechaActualBancoCentralImpuestoUsd { get; set; }
        public decimal? FechaActualBancoCentralSaldoUsd { get; set; }
        public decimal? FechaActualBancoCentralTasa { get; set; }
        public decimal? FechaActualBancoCentralRetencionPendienteUsd { get; set; }
      

        public decimal? FechaActualReferencialMontoUsd { get; set; }
        public decimal? FechaActualReferencialBaseImponibleUsd { get; set; }
        public decimal? FechaActualReferencialImpuestoUsd { get; set; }
        public decimal? FechaActualReferencialSaldoUsd { get; set; }
        public decimal? FechaActualReferencialTasa { get; set; }
        public decimal? FechaActualReferencialRetencionPendienteUsd { get; set; }

        public decimal? FechaActualReferencialCotizacionMontoUsd { get; set; }
        public decimal? FechaActualReferencialCotizacionBaseImponibleUsd { get; set; }
        public decimal? FechaActualReferencialCotizacionImpuestoUsd { get; set; }
        public decimal? FechaActualReferencialCotizacionSaldoUsd { get; set; }
        public decimal? FechaActualReferencialCotizacionTasa { get; set; }
        public decimal? FechaActualReferencialCotizacionRetencionPendienteUsd { get; set; }

        public string CodigoRegion { get; set; }
        public string Region { get; set; }
        public string DebeHaber { get; set; }
        public string Signo { get; set; }
        public string Texto { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public bool FacturaTieneRetencionesPendientes { get; set; }
        public decimal? RetencionPendiente { get; set; }

     
    }
}
