using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Secuencia
    {
        public decimal Id { get; set; }
        public decimal IdRuta { get; set; }
        public decimal Secuencia1 { get; set; }
        public decimal IdEstacion { get; set; }
        public decimal? DiasPredeterminados { get; set; }
    }
}
