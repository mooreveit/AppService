﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class TotalCuotasGrupo
    {
        public decimal? Cuota { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Ano { get; set; }
        public string CodigoGrupo { get; set; }
    }
}
