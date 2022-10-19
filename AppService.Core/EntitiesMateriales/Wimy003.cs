using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMateriales
{
    public partial class Wimy003
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; }
        public string Brillo { get; set; }
        public string Color { get; set; }
        public string Imagen { get; set; }
        public string Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
