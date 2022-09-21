using System;
using System.Collections.Generic;

namespace AppService.Core.DTOs
{
    public class AppProductsGetDto
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public int? AppUnitsId { get; set; }

        public int? ProductionUnitId { get; set; }

        public Decimal UnitPrice { get; set; }

        public string UrlImage { get; set; }

        public string ExternalCode { get; set; }

        public long? PrymaryMtrMonedaId { get; set; }

        public long? SecundaryMtrMonedaId { get; set; }

        public int? AppSubCategoryId { get; set; }

        public string Link { get; set; }

        public int QuantityPerPackage { get; set; }

        public bool? ValidadCantidadFija { get; set; }

        public Decimal? CantidadFija { get; set; }

        public bool AceptaMultiplesItem { get; set; }

        public bool RequiereDatosEntrada { get; set; }

        public bool PrecioPorRango { get; set; }

        public Decimal? Existencia { get; set; }

        public Decimal? CajasProgramadas { get; set; }

        public Decimal? Disponible { get; set; }

        public Decimal? CantidadMinima { get; set; }

        public string VariablesSearchText { get; set; }

        public int TipoCalculo { get; set; }

        public AppUnitsGetDto AppUnitsGetDto { get; set; }

        public AppUnitsGetDto ProductionUnitGetDto { get; set; }

        public MtrTipoMonedaDto PrymaryMtrMonedaGetDto { get; set; }

        public MtrTipoMonedaDto SecundaryMtrMonedaGetDto { get; set; }

        public AppSubCategoryGetDto AppSubCategoryGetDto { get; set; }

        public List<AppService.Core.DTOs.AppPriceDto> AppPriceDto { get; set; }

        public List<AppProductConversionGetDto> Conversiones { get; set; }

        public List<AppProductVariableSearchTextDto> Caracteristicas { get; set; }

    }
}
