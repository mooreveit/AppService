using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class MontoOrdenes
    {
        public decimal NumCot { get; set; }
        public DateTime? FecGrab { get; set; }
        public string Oficina { get; set; }
        public float? VentaTot { get; set; }
        public float? ListaTot { get; set; }
    }
}
