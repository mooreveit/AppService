using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapAuxiliarContrapartidaTransaccion
    {
        public decimal Id { get; set; }
        public string CuentaAuxiliar { get; set; }
        public string CuentaContrapartida { get; set; }
        public string TipoTransaccion { get; set; }
    }
}
