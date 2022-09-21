using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Sysfile
    {
        public decimal Recnum { get; set; }
        public string CompanyName { get; set; }
        public short? LargoPagina { get; set; }
        public short? SaltoPagina { get; set; }
        public short? Bodega { get; set; }
        public short? CierreMesCpo { get; set; }
        public short? CierreAnoCpo { get; set; }
        public short? CierreMesNim { get; set; }
        public short? CierreAnoNim { get; set; }
        public DateTime? DiaCerradoCpo { get; set; }
        public DateTime? DiaCerradoNim { get; set; }
        public DateTime? CierreFactura { get; set; }
        public int? UltComprobante { get; set; }
        public DateTime Hoy { get; set; }
        public decimal? Sobretiro { get; set; }
        public decimal? Diasvigenciaclave { get; set; }
        public DateTime? Fechaobsolescencia { get; set; }
        public string CorreoDestinoIc { get; set; }
        public string CorreoCopiaIc { get; set; }
        public int? DesdeNumeroAleatorio { get; set; }
        public int? HastaNumeroAleatorio { get; set; }
        public string RutaServidorAdjuntos { get; set; }
        public string RutaArchivosAdjuntos { get; set; }
        public string UsuarioForecastNomina { get; set; }
        public string CorreoAdministradorForecast { get; set; }
        public int? SegWebIntentosFallidos { get; set; }
        public int? SegWebDiasExpiraClave { get; set; }
        public int? SegWebDiasAvisoCambio { get; set; }
        public int IdRolAprobadorPrelista { get; set; }
        public string FlagReglaPesoDimensionPrelista { get; set; }
        public string ServerVinculadoJde { get; set; }
        public string ServerVinculadoOd { get; set; }
        public int? AñoGeneraPdfFactura { get; set; }
        public int? MesGeneraPdfFactura { get; set; }
        public int? DiaGeneraPdfFactura { get; set; }
        public int? AñoGeneraPdfRemision { get; set; }
        public int? MesGeneraPdfRemision { get; set; }
        public int? DiaGeneraPdfRemision { get; set; }
        public int? AñoGeneraPdfOrigen { get; set; }
        public int? MesGeneraPdfOrigen { get; set; }
        public int? DiaGeneraPdfOrigen { get; set; }
        public decimal? PorcGeneralGanancia { get; set; }
        public decimal? PorcGananciaDeLey { get; set; }
        public decimal? PorcGananciaCadenaDistribucion { get; set; }
        public bool? ValidarCredito { get; set; }
        public decimal? UltimoCepPrint { get; set; }
        public bool? ImprimeTituloMoneda { get; set; }
        public string TituloMoneda { get; set; }
        public int? MesInicioAcumuladoVentaParaComisiones { get; set; }
        public bool? EjecutarAjustesUsd { get; set; }
        public bool? ActualizarFechaPago { get; set; }
    }
}
