using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req020
    {
        public byte Id { get; set; }
        public byte IdEstacion { get; set; }
        public string Abreviado { get; set; }
        public string Descripcion { get; set; }
        public string FlagAprobacion { get; set; }
        public string FlagCancelado { get; set; }
        public string FlagTerminado { get; set; }
        public string FlagFechaEntrega { get; set; }
        public string FlagScript { get; set; }
        public string FlagHpsm { get; set; }
    }
}
