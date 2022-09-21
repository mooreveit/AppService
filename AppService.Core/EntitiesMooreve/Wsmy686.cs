using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy686
    {
        public int Id { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public bool Activo { get; set; }
        public string DescPeriodo { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime FechaActualiza { get; set; }
        public bool? PeriodoCerrado { get; set; }
        public DateTime? FechaCerrado { get; set; }
    }
}
