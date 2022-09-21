using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class OrdenesRechazadasAdmin
    {
        public decimal NumCot { get; set; }
        public string EmailAdmin { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }
    }
}
