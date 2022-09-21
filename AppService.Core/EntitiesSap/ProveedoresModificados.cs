using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class ProveedoresModificados
    {
        public decimal Id { get; set; }
        public string Mandt { get; set; }
        public string Lifnr { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
