using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy595
    {
        public long IdRegistro { get; set; }
        public long Orden { get; set; }
        public long JobId { get; set; }
        public string CodProducto { get; set; }
        public string Observaciones { get; set; }
        public string EquipoInsert { get; set; }
        public string UsuarioInsert { get; set; }
        public DateTime FechaInsert { get; set; }
    }
}
