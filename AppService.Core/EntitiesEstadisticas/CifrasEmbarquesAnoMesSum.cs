using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesAnoMesSum
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string TipoProdu { get; set; }
        public decimal? ValorVentaJob { get; set; }
        public decimal? ValorListaJob { get; set; }
        public decimal? BsmcJob { get; set; }
    }
}
