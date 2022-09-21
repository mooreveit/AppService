using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaTroqueles
    {
        public int RecordNumber { get; set; }
        public string Prefijo { get; set; }
        public decimal Numero { get; set; }
        public string Sufijo { get; set; }
        public decimal CantidadXAnch { get; set; }
        public string LinerAnchoRol { get; set; }
        public string LinerAnchoDob { get; set; }
        public string LinerLargo { get; set; }
        public string EtiquetaAncho { get; set; }
        public string EtiquetaLargo { get; set; }
        public decimal? CantidadXLarg { get; set; }
        public decimal? EtiquetaXVuel { get; set; }
        public string Nodisponible { get; set; }
    }
}
