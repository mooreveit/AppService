using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class EmailVendedores
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Supervisor { get; set; }
        public string EMail { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string Oficina { get; set; }
    }
}
