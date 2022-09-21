using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry220
    {
        public int IdDetalleConsulta { get; set; }
        public int IdConsulta { get; set; }
        public int IdEstatus { get; set; }
        public int? IdUsuario { get; set; }
        public string Comentarios { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaStandBy { get; set; }
    }
}
