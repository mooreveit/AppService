using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaVariablesReporte
    {
        public decimal Id { get; set; }
        public string Variable { get; set; }
        public string Nombre { get; set; }
        public decimal? Orden { get; set; }
        public string VariablePadre { get; set; }
    }
}
