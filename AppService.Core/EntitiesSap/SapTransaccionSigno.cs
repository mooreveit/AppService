using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapTransaccionSigno
    {
        public decimal Id { get; set; }
        public string Transaccion { get; set; }
        public decimal? Signo { get; set; }
    }
}
