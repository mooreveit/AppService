﻿using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    /// <summary>
    /// TRANSACCIONES PERMANENTE  CXC
    /// </summary>
    public partial class Wary074
    {
        public decimal Recnum { get; set; }
        public int Cliente { get; set; }
        public string Transaccion { get; set; }
        public int Documento { get; set; }
        public short Linea { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVcto { get; set; }
        public decimal? Monto { get; set; }
        public string TipoCanc { get; set; }
        public int DocCanc { get; set; }
        public short? LinCanc { get; set; }
        public decimal? Saldo { get; set; }
        public int? Referencia { get; set; }
        public string NoTieneDebe { get; set; }
        public string Eliminar { get; set; }
        public short? Comprobante { get; set; }
        public short? CompLinea { get; set; }
        public short? AO { get; set; }
        public short? Mes { get; set; }
        public string Region { get; set; }
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public string Matriz { get; set; }
        public string Supervisor { get; set; }
        public string Cobrador { get; set; }
        public string Moneda { get; set; }
        public decimal? MontoMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public short PlantaOficina { get; set; }
        public string CuentaEfecto { get; set; }
        public string Concepto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int? InformeQueja { get; set; }
        public string Banco { get; set; }
        public DateTime? FechaPlanilla { get; set; }
        public string TipoCompania { get; set; }
        public DateTime? UltimoPago { get; set; }
        public DateTime? FechaCobro { get; set; }
        public short? VecesCobro { get; set; }
        public int? RelacionCobro { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaUsuario { get; set; }
        public short? HoraUsario { get; set; }
        public short? MinutosUsuario { get; set; }
        public string Estado { get; set; }
        public string TipoCiudad { get; set; }
        public string Tipo { get; set; }
        public string Ciudad { get; set; }
        public int? Remisionsi { get; set; }
        public int? Remisionma { get; set; }
        public string Status { get; set; }
        public string RegionActual { get; set; }
        public string GrupoActual { get; set; }
        public short? AsigActual { get; set; }
        public decimal? PorIva { get; set; }
        public string Comisionpagada { get; set; }
        public string Vendedor { get; set; }
        public int? Dias { get; set; }
        public DateTime FechaEntrega { get; set; }
        public long? Orden { get; set; }
        public int? DiasEntrega { get; set; }
        public string Contabilizado { get; set; }
        public short? CondPago { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? SaldoDolar { get; set; }
        public decimal? Cambio { get; set; }
        public int? Anticipo { get; set; }
        public string Cotizacion { get; set; }
        public string Recalcular { get; set; }
        public string PasoSql { get; set; }
        public string Observacion1 { get; set; }
        public string Observacion2 { get; set; }
        public string Diferencial { get; set; }
        public string Lote { get; set; }
        public string Afectanota { get; set; }
        public string Nombre { get; set; }
        public string Efectivo { get; set; }
        public string Nrocheque { get; set; }
        public string Transferencia { get; set; }
        public DateTime? Fechadoccanc { get; set; }
        public long? Diastransc { get; set; }
        public short? Estacion { get; set; }
        public string RecibidaPl { get; set; }
        public string PasoJde { get; set; }
        public string Depura { get; set; }
        public long? NumeroPl { get; set; }
        public DateTime? FecrecibPl { get; set; }
        public decimal? DocJde { get; set; }
        public string ComisionPag { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string HoraCreacion { get; set; }
        public decimal? Rmonto { get; set; }
        public decimal? Rsaldo { get; set; }
        public decimal? Porcret { get; set; }
        public string Rzvre { get; set; }
        public double? Batch { get; set; }
        public string NroPlanilla { get; set; }
        public string CodContrapart { get; set; }
        public int? DocAnterior { get; set; }
    }
}
