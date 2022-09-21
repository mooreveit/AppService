using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class QueryEstadistAac01
    {
        public decimal NumCot { get; set; }
        public DateTime? FecGrab { get; set; }
        public DateTime? FecAproCob { get; set; }
        public string AprobCob1 { get; set; }
        public string Estado { get; set; }
    }
}
