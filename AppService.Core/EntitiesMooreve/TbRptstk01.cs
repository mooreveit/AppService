using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class TbRptstk01
    {
        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? B11 { get; set; }
        public int? B22 { get; set; }
        public int? B27 { get; set; }
        public int? Existencia { get; set; }
        public int? CajasProgramadas { get; set; }
        public int? Disponible { get; set; }
    }
}
