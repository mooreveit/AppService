using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VTintasordene
    {
        public long Orden { get; set; }
        public string Tinta { get; set; }
        public string FlagNoContar { get; set; }
    }
}
