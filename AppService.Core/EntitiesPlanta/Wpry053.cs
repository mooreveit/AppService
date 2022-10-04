using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry053
    {
        public decimal Recnum { get; set; }
        public string Usuario { get; set; }
        public decimal Orden { get; set; }
        public long Job { get; set; }
        public string Cliente { get; set; }
        public decimal CtdProgramada { get; set; }
        public decimal CtdPendiente { get; set; }
        public short Partes { get; set; }
        public string Prensa { get; set; }
        public string Colectora { get; set; }
        public DateTime? FechaOrden { get; set; }
        public DateTime? FechaOrdenPro { get; set; }
        public DateTime? FechaProgEsta { get; set; }
        public short DiasAtrasoEst { get; set; }
        public short DiasAtrasoGen { get; set; }
        public decimal Lista { get; set; }
        public long Venta { get; set; }
        public string Programada { get; set; }
        public string Status { get; set; }
        public string Estacion { get; set; }
        public string Depto { get; set; }
        public string Linea { get; set; }
        public string MillProg { get; set; }
        public string MillPdte { get; set; }
        public short RestarBacklog { get; set; }
        public short MaqSort { get; set; }
        public long Rollitos { get; set; }
        public string Reoperacion { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string AcumulaPrensas { get; set; }
        public string AcumulaColecto { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? ValorMc { get; set; }
        public short? DiasEstacion { get; set; }
        public DateTime? FechaEst { get; set; }
        public DateTime? Fechareal { get; set; }
        public short? Diareal { get; set; }
        public short? TotalDiasProg { get; set; }
        public decimal? RvalorMc { get; set; }
    }
}
