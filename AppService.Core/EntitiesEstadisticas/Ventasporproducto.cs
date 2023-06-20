using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Ventasporproducto
    {
        public decimal? Ano { get; set; }
        public decimal? Mes { get; set; }
        public string LineaProduc { get; set; }
        public decimal? Ventas { get; set; }
        public decimal? Lista { get; set; }
        public string Descripcion { get; set; }
    }
}
