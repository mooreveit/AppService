using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Rcl011
    {
        public string IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string IdProceso { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public DateTime Fecha { get; set; }
        public string Adjunto { get; set; }
        public string IdEstatus { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaGenerado { get; set; }
        public DateTime? FechaCerrado { get; set; }
    }
}
