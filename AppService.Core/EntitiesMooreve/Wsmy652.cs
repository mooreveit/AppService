using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy652
    {
        public decimal RecNum { get; set; }
        public string IdUsuario { get; set; }
        public short IdCategoria { get; set; }
        public decimal? Porcentaje { get; set; }
        public bool? FlagActivo { get; set; }
        public bool? FlagAprobador { get; set; }
        public DateTime FechaActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
        public decimal? PorcentajeMin { get; set; }
    }
}
