using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy516
    {
        public long IdRegistro { get; set; }
        public long Orden { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public DateTime FechaArchivo { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioArchivo { get; set; }
        public DateTime? FechaSalidaArchivo { get; set; }
    }
}
