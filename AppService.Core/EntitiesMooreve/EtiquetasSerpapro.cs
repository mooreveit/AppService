using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EtiquetasSerpapro
    {
        public long IdRegistro { get; set; }
        public long Orden { get; set; }
        public string CodigoPrefijo { get; set; }
        public string NroCorrelativo { get; set; }
        public short EtiquetasPorHoja { get; set; }
    }
}
