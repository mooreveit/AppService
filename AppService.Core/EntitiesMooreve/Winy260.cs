using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Winy260
    {
        public long IdSolicitud { get; set; }
        public long Orden { get; set; }
        public string IdProducto { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string IdSolicitante { get; set; }
        public string MotivoSolicitud { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string IdAprobador { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string IdUsuarioProceso { get; set; }
    }
}
