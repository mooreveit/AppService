using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req030
    {
        public long IdLogObsTarea { get; set; }
        public long IdTarea { get; set; }
        public byte IdEstacion { get; set; }
        public string IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; }
        public string FlagCorreo { get; set; }
        public string FlagEnviado { get; set; }
    }
}
