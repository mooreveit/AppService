using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class CifrasEmbarquesAnoMesImp
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string TipoProdu { get; set; }
        public decimal? ValorVentaImp { get; set; }
        public decimal? ValorListaImp { get; set; }
        public decimal? BsmcImp { get; set; }
    }
}
