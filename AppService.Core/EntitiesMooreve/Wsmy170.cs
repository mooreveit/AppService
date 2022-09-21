using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy170
    {
        public int Id { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public short? Periodo { get; set; }
        public string Activo { get; set; }
        public string DescPeriodo { get; set; }
    }
}
