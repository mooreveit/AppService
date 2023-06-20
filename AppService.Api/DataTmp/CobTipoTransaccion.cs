using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobTipoTransaccion
    {
        public string IdTipoTransaccion { get; set; }
        public string NombreTipoTransaccion { get; set; }
        public bool FlagActivaVerificacion { get; set; }
        public bool FlagImpuesto { get; set; }
        public bool FlagCotizador { get; set; }
        public string IdTipoPagoSap { get; set; }
        public string ColetillaIva { get; set; }
    }
}
