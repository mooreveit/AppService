using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy548
    {
        public int IdActividad { get; set; }
        public int IdProductoCuota { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string IdUsuarioActualiza { get; set; }
    }
}
