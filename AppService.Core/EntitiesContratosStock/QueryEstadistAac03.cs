using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class QueryEstadistAac03
    {
        public string NumCot { get; set; }
        public decimal? IdMotivo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FecAproCob { get; set; }
    }
}
