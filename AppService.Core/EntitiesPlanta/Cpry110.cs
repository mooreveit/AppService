﻿using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry110
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public string FlagActivo { get; set; }
        public string Job { get; set; }
    }
}
