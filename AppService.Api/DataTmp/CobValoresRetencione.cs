using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobValoresRetencione
    {
        public long IdTransaccion { get; set; }
        public string Valores { get; set; }
        public bool FlagRango { get; set; }
        public bool FlagValorFijo { get; set; }
        public bool FlagRetieneSobreImp { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
