using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy696
    {
        public decimal Recnum { get; set; }
        public string Ficha { get; set; }
        public int IdSubCategoria { get; set; }
        public decimal PorcCoberturaDesde { get; set; }
        public decimal PorcCoberturaHasta { get; set; }
        public decimal PorcComision { get; set; }
        public string UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }

        public virtual Wsmy437 IdSubCategoriaNavigation { get; set; }
    }
}
