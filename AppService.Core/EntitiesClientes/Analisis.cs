using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Analisis
    {
        public int RecordNumber { get; set; }
        public decimal? Cliente { get; set; }
        public string Transaccion { get; set; }
        public decimal? Documento { get; set; }
        public decimal? Linea { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVcto { get; set; }
        public decimal? Monto { get; set; }
        public string TipoCanc { get; set; }
        public decimal? DocCanc { get; set; }
        public decimal? LinCanc { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Referencia { get; set; }
        public string NoTieneDebe { get; set; }
        public string Eliminar { get; set; }
        public decimal? Comprobante { get; set; }
        public decimal? CompLinea { get; set; }
        public decimal? AO { get; set; }
        public decimal? Mes { get; set; }
        public string Region { get; set; }
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public string Matriz { get; set; }
        public string Supervisor { get; set; }
        public string Cobrador { get; set; }
        public string Moneda { get; set; }
        public decimal? MontoMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? PlantaOficina { get; set; }
        public string CuentaEfecto { get; set; }
        public string CodContrapart { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? InformeQueja { get; set; }
        public string Banco { get; set; }
        public decimal? NroPlanilla { get; set; }
        public DateTime? FechaPlanilla { get; set; }
        public string TipoCompania { get; set; }
        public DateTime? UltimoPago { get; set; }
        public DateTime? FechaCobro { get; set; }
        public decimal? VecesCobro { get; set; }
        public decimal? RelacionCobro { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaUsuario { get; set; }
        public decimal? HoraUsario { get; set; }
        public decimal? MinutosUsuario { get; set; }
        public string CodMoore { get; set; }
        public string Estado { get; set; }
        public string TipoCiudad { get; set; }
        public string Tipo { get; set; }
        public string Ciudad { get; set; }
        public decimal? Remisionsi { get; set; }
        public decimal? Remisionma { get; set; }
        public string Status { get; set; }
        public string RegionActual { get; set; }
        public string GrupoActual { get; set; }
        public decimal? AsigActual { get; set; }
        public decimal? PorIva { get; set; }
        public string Facdoc { get; set; }
        public string Comisionpagada { get; set; }
        public string Vendedor { get; set; }
        public decimal? Dias { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal? Orden { get; set; }
        public decimal? DiasEntrega { get; set; }
        public string Contabilizado { get; set; }
        public decimal? CondPago { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? SaldoDolar { get; set; }
        public decimal? Cambio { get; set; }
        public decimal? Anticipo { get; set; }
        public string Cotizacion { get; set; }
        public string Recalcular { get; set; }
        public string PasoSql { get; set; }
        public string Observacion1 { get; set; }
        public string Observacion2 { get; set; }
        public string Diferencial { get; set; }
        public string Lote { get; set; }
        public string Afectanota { get; set; }
    }
}
