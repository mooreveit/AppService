using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req029
    {
        public long IdLogObsReq { get; set; }
        public long IdRequerimiento { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string FlagCorreo { get; set; }
        public string FlagEnviado { get; set; }
    }
}
