using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class ConsumoPorFechaCodigoFifo
    {
        public DateTime? FechaTransac { get; set; }
        public string Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Ctainv { get; set; }
        public string Ctacon { get; set; }
        public DateTime? Expr1 { get; set; }
    }
}
