using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Deslin
    {
        public decimal Recnum { get; set; }
        public short Partes { get; set; }
        public string MetodoPrecio { get; set; }
        public string Papel { get; set; }
        public string Descripcion { get; set; }
    }
}
