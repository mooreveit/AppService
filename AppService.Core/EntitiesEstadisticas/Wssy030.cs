using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Wssy030
    {
        public int? RecordNumber { get; set; }
        public string CodigoRegion { get; set; }
        public string NombreRegion { get; set; }
        public string GerenteRegion { get; set; }
        public decimal? OverrideRegion { get; set; }
    }
}
