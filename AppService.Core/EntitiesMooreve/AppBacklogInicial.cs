using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AppBacklogInicial
    {
        public int Id { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? CantBacklogInicial { get; set; }
        public decimal? BsBacklogInicial { get; set; }
        public decimal? UsdbacklogInicial { get; set; }
        public decimal? RbsBacklogInicial { get; set; }
    }
}
