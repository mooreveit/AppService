using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdObservacionAdjunto
    {
        public long IdObservacionAdjunto { get; set; }
        public long IdAdjunto { get; set; }
        public string Observaciones { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
