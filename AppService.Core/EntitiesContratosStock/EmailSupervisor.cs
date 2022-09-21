using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class EmailSupervisor
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string EMail { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string FlagDeGerente { get; set; }
        public string FlagSupervisor { get; set; }
    }
}
