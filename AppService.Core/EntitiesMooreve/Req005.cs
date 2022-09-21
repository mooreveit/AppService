using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req005
    {
        public short Id { get; set; }
        public short IdSubCategoria { get; set; }
        public string Descripcion { get; set; }
        public byte IdCategoria { get; set; }
        public string FlagAdjunto { get; set; }
        public string FlagAplicacion { get; set; }
        public byte IdRuta { get; set; }
        public string FlagScript { get; set; }
        public string FlagHpsm { get; set; }
    }
}
