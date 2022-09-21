using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class ZonaTransporte
    {
        public decimal Id { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoMcpo { get; set; }
        public string Codigosap { get; set; }
    }
}
