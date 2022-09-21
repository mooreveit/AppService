using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class ClientesModificados
    {
        public decimal Id { get; set; }
        public string Mandt { get; set; }
        public string Kunnr { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Procesado { get; set; }
    }
}
