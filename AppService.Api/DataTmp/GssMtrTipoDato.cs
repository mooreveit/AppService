using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssMtrTipoDato
    {
        public string IdTipoDato { get; set; }
        public string MascaraUsuario { get; set; }
        public string MensajeUsuario { get; set; }
        public bool FlagValidar { get; set; }
        public short Orden { get; set; }
        public string TipoDatoDatatables { get; set; }
    }
}
