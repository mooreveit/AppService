using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl006
    {
        public int IdDiaFeriado { get; set; }
        public DateTime FechaFeriado { get; set; }
        public int IdPais { get; set; }
        public string DescripcionFeriado { get; set; }

        public virtual Rcl003 IdPaisNavigation { get; set; }
    }
}
