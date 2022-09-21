using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class CondicionDePagoDeudores
    {
        public decimal Id { get; set; }
        public short? CondicionLegacy { get; set; }
        public string Descripcion { get; set; }
        public string CondicionJde { get; set; }
        public string CondicionSap { get; set; }
        public int? DiasDeudores { get; set; }
        public int? DiasAcreedores { get; set; }
    }
}
