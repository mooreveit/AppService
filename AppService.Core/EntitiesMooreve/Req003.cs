using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req003
    {
        public byte Id { get; set; }
        public byte IdPrioridad { get; set; }
        public string Descripcion { get; set; }
        public byte Secuencia { get; set; }
        public string FlagPredefinido { get; set; }
    }
}
