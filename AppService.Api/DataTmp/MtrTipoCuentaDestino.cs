using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrTipoCuentaDestino
    {
        public MtrTipoCuentaDestino()
        {
            MtrBancos = new HashSet<MtrBanco>();
        }

        public int IdTipoCuentaDestino { get; set; }
        public string NombreCuentaDestino { get; set; }

        public virtual ICollection<MtrBanco> MtrBancos { get; set; }
    }
}
