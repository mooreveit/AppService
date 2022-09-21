using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy431
    {
        public string Cotizacion { get; set; }
        public decimal Orden { get; set; }
        public decimal Documento { get; set; }
        public decimal TipoDoc { get; set; }
        public decimal Linea { get; set; }
        public decimal Monto { get; set; }
        public decimal? DocumentoJde { get; set; }
        public decimal? LineaJde { get; set; }
        public decimal? Rmonto { get; set; }
    }
}
