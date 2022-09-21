using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TPaCuentasContablePorVariableAñoMes
    {
        public decimal Id { get; set; }
        public string Glani { get; set; }
        public string IdVariables { get; set; }
        public decimal Año { get; set; }
        public decimal Mes { get; set; }
        public decimal Monto { get; set; }
    }
}
