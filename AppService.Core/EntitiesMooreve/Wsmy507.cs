using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy507
    {
        public decimal Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Semana { get; set; }
        public int? Categoria { get; set; }
        public string DescCategoria { get; set; }
        public int? SubCategoria { get; set; }
        public string DescSubCategoria { get; set; }
        public decimal? Estimado { get; set; }
    }
}
