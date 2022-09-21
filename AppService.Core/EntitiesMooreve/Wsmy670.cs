using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy670
    {
        public decimal Recnum { get; set; }
        public int IdSubCategoria { get; set; }
        public decimal PorcComision { get; set; }
        public decimal PorcCoberturaDesde { get; set; }
        public decimal PorcCoberturaHasta { get; set; }
        public string UsuarioCrea { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        public virtual Wsmy437 IdSubCategoriaNavigation { get; set; }
    }
}
