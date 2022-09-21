using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wsmy063
    {
        public decimal Recnum { get; set; }
        public string Tipo { get; set; }
        public string NombreTipo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string TipoLegacy { get; set; }
    }
}
