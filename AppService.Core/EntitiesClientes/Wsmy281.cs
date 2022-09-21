using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class Wsmy281
    {
        public long IdRegistro { get; set; }
        public int Solicitud { get; set; }
        public int Oficina { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }
    }
}
