using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapCuentaEfectivo
    {
        public decimal Id { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
    }
}
