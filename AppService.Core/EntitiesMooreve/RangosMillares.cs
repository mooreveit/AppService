using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class RangosMillares
    {
        public decimal Id { get; set; }
        public decimal? Desde { get; set; }
        public decimal? Hasta { get; set; }
        public string Titulo { get; set; }
    }
}
