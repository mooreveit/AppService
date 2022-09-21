using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class OrdenesRechazadas
    {
        public decimal NumCot { get; set; }
        public string EmailVendedor { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
    }
}
