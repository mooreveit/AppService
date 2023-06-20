using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesAnoMesOut
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string TipoProdu { get; set; }
        public decimal? ValorVentaOut { get; set; }
        public decimal? ValorListaOut { get; set; }
        public decimal? BsmcOut { get; set; }
    }
}
