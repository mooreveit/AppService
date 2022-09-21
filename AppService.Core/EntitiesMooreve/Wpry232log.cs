using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry232log
    {
        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public short IdSubcategoria { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public string UsuarioElimino { get; set; }
    }
}
