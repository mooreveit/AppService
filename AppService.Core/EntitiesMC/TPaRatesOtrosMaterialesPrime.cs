using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaRatesOtrosMaterialesPrime
    {
        public int Id { get; set; }
        public decimal? RateTinta { get; set; }
        public decimal? RatePlaca { get; set; }
        public decimal? RateCajasBs { get; set; }
        public decimal? RateCajasKg { get; set; }
        public decimal? RateOtrosMateriales { get; set; }
        public decimal? RateTransferTape { get; set; }
        public decimal? RateTintaCarbonSpot { get; set; }
        public decimal? RateCajasBsRollos { get; set; }
        public decimal? RateCajasRollos { get; set; }
        public decimal? RatePlacaEtiqueta { get; set; }
        public decimal? RateCoresRollos { get; set; }
        public decimal? RateBarnizUv { get; set; }
        public decimal? RateRibbon { get; set; }
        public decimal? RateCartonLigas { get; set; }
        public decimal? RateAnimes { get; set; }
        public decimal? RatePolifilm { get; set; }
        public decimal? RateColdFoil { get; set; }
        public decimal? RateTroquel { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModifico { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? TipoCalculo { get; set; }
    }
}
