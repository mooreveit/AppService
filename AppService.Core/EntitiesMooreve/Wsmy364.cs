using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy364
    {
        public string NroCotizacion { get; set; }
        public int NumPropuesta { get; set; }
        public int NumCalculo { get; set; }
        public decimal Orden { get; set; }
        public short? NumPartes { get; set; }
        public decimal? TipoOrden { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? PosNum { get; set; }
        public decimal? TipoNum { get; set; }
        public decimal? OrientaNum { get; set; }
        public string FlagVe19 { get; set; }
        public string FlagFiscal { get; set; }
        public string FlagSobreTiro { get; set; }
        public string FlagBajoTiro { get; set; }
        public string FlagFaltante { get; set; }
        public string FlagEngrape { get; set; }
        public string Prefijo { get; set; }
        public string Sufijo { get; set; }
        public string ParteNumMag { get; set; }
        public string NumControlD { get; set; }
        public string NumControlH { get; set; }
        public int? ReferForma { get; set; }
        public int? NumPropComb { get; set; }
        public int? NumCalComb { get; set; }
        public string FlagNumMagnetica { get; set; }
        public string PieImp { get; set; }
        public string CantExacta { get; set; }
        public string CheckNum { get; set; }
        public string CheckNumMag { get; set; }
        public string CheckHoyos { get; set; }
        public string CheckPerf { get; set; }
        public decimal? NumPlanillaCn { get; set; }
        public string ValidaPlanilla { get; set; }
        public string NumCot { get; set; }
        public string Actualizado { get; set; }
        public decimal? Formasxcajas { get; set; }
        public short? Cantcajas { get; set; }
        public string Tipocaja { get; set; }
        public short? Empaque { get; set; }
        public string FlagPrueba { get; set; }
        public decimal? Formaxpaq { get; set; }
        public short? Totalpaq { get; set; }
        public string FlagCodbarra { get; set; }
        public string PrefCli { get; set; }
        public string SufiCli { get; set; }
        public string NumCliDesde { get; set; }
        public string NumCliHasta { get; set; }
        public string TipoDocumento { get; set; }
        public short? Mascara { get; set; }
    }
}
