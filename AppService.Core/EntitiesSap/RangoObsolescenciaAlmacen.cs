using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class RangoObsolescenciaAlmacen
    {
        public string Almacen { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public decimal? Porc { get; set; }
        public string TipoInventario { get; set; }
        public decimal Id { get; set; }
    }
}
