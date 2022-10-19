using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy007
    {
        public decimal Recnum { get; set; }
        public string CodigoZona { get; set; }
        public string DescripcionZon { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string Maquina { get; set; }
        public string ValidarPapel { get; set; }
        public string ValidarMaquina { get; set; }
    }
}
