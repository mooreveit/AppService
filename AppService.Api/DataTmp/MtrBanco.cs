using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrBanco
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodContable { get; set; }
        public string AplicaImp { get; set; }
        public string TraAsociada { get; set; }
        public string ProdGenerico { get; set; }
        public string TraJde { get; set; }
        public bool FlagActivo { get; set; }
        public bool FlagIngreso { get; set; }
        public bool FlagEgreso { get; set; }
        public int IdTipoCuentaDestino { get; set; }

        public virtual MtrTipoCuentaDestino IdTipoCuentaDestinoNavigation { get; set; }
    }
}
