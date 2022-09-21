using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy272
    {
        public decimal? CodSolicitud { get; set; }
        public decimal? CodOficina { get; set; }
        public decimal? CodCliente { get; set; }
        public string ObservRechazo { get; set; }
        public string UserRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public int? CodMotivo { get; set; }
        public int? CodGrupo { get; set; }
        public long IdRegistro { get; set; }
    }
}
