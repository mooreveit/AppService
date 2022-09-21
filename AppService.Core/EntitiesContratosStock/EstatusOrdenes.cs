using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class EstatusOrdenes
    {
        public string CodigoEstatus { get; set; }
        public string Descripcion { get; set; }
        public string AfectaBacklog { get; set; }
        public string FlagEnviado { get; set; }
        public string FlagModifica { get; set; }
    }
}
