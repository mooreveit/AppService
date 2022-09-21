using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req011
    {
        public byte Id { get; set; }
        public string Estatus { get; set; }
        public string Descripcion { get; set; }
        public string FlagPendiente { get; set; }
        public string FlagAprobado { get; set; }
        public string FlagFinalizado { get; set; }
        public string FlagCancelado { get; set; }
    }
}
