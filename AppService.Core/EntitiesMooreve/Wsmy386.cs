using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy386
    {
        public decimal Id { get; set; }
        public string NroCotizacion { get; set; }
        public int NroPropuesta { get; set; }
        public int CorrelativoCal { get; set; }
        public int IdPropuesta { get; set; }
        public int IdCalculo { get; set; }
        public decimal? PorcVendedor { get; set; }
        public decimal? BolivVendedor { get; set; }
        public decimal? PorcTeamLider { get; set; }
        public decimal? BolivTeamLider { get; set; }
        public decimal? PorcGerOfic { get; set; }
        public decimal? BolivGerOfic { get; set; }
        public decimal? PorcGerRegion { get; set; }
        public decimal? BolivGerRegion { get; set; }
        public decimal? PorcGerImpCom { get; set; }
        public decimal? BolivGerImpCom { get; set; }
        public decimal? PorcSupImpCom { get; set; }
        public decimal? BolivSupImpCom { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Observacion { get; set; }
        public string Activo { get; set; }
        public int? Tabla { get; set; }
        public decimal? RbolivVendedor { get; set; }
        public decimal? RbolivTeamLider { get; set; }
        public decimal? RbolivGerOfic { get; set; }
        public decimal? RbolivGerRegion { get; set; }
        public decimal? RbolivGerImpCom { get; set; }
        public decimal? RbolivSupImpCom { get; set; }
    }
}
