using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VVendedoresMarketing
    {
        public string Oficina { get; set; }
        public string Gerente { get; set; }
        public string TeamLider { get; set; }
        public string Vendedor { get; set; }
        public string CodigoVendedor { get; set; }
        public int DiasCalle { get; set; }
        public string DesCategoria { get; set; }
        public string Activo { get; set; }
        public int? Meses { get; set; }
    }
}
