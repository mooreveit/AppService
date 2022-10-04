using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry055
    {
        public decimal Recnum { get; set; }
        public string Usuario { get; set; }
        public long Orden { get; set; }
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
        public long Lista { get; set; }
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
        public string Oficina { get; set; }
        public decimal Tasa { get; set; }
        public decimal DolUnit { get; set; }
        public decimal DolTotOrden { get; set; }
        public long CantidadOrden { get; set; }
        public string Vendedor { get; set; }
        public string SiDolar { get; set; }
        public string MillOrden { get; set; }
        public string CondPago { get; set; }
        public short ContarOrden { get; set; }
        public decimal? Rtasa { get; set; }
    }
}
