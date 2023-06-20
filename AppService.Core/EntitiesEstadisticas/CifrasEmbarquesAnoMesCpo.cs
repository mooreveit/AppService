using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesAnoMesCpo
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string TipoProdu { get; set; }
        public decimal? ValorVentaCpo { get; set; }
        public decimal? ValorListaCpo { get; set; }
        public decimal? BsmcCpo { get; set; }
    }
}
