using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaCostoAñoMesManodeObraCargaFabrilPorPieJj
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? CostoManoDeObraPrensaPorPie { get; set; }
        public decimal? CostoManoDeObraColectoraPorPie { get; set; }
        public decimal? CostoCargaFabrilPrensaPorPie { get; set; }
        public decimal? CostoCargaFabrilColectoraPorPie { get; set; }
        public decimal? CostoManoDeObraEtiquetas { get; set; }
        public decimal? CostoCargaFabrilEtiquetas { get; set; }
        public decimal? Costodistribucion { get; set; }
        public decimal? CostodistribucionComprado { get; set; }
        public decimal? CostoPlacaPorPie { get; set; }
        public decimal? CostoManoDeObraPrensaPorPieShortRun { get; set; }
        public decimal? CostoManoDeObraColectoraPorPieShortRun { get; set; }
        public decimal? CostoCargaFabrilPrensaPorPieShortRun { get; set; }
        public decimal? CostoCargaFabrilColectoraPorPieShortRun { get; set; }
        public decimal? CostoManoObraPrensaPrime { get; set; }
        public decimal? CostoManoObraAcabadoPrime { get; set; }
        public decimal? RateCargaFabrilPrime { get; set; }
        public int? TipoRate { get; set; }
    }
}
