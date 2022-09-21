using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy063
    {
        public int Tipo { get; set; }
        public string NombreTipo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string EsGobierno { get; set; }
        public string TipoSap { get; set; }
    }
}
