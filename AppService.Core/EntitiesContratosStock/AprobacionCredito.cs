using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class AprobacionCredito
    {
        public string CodOfic { get; set; }
        public string UnidadesTrib { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Rmonto { get; set; }
    }
}
