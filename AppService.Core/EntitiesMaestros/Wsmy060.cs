using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wsmy060
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string NombreEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
    }
}
