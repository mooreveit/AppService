using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry232
    {
        public int Recnum { get; set; }
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int Propuesta { get; set; }
        public short IdSubcategoria { get; set; }

        public virtual Wsmy501 CotizacionNavigation { get; set; }
        public virtual Wpry234 IdSubcategoriaNavigation { get; set; }
    }
}
